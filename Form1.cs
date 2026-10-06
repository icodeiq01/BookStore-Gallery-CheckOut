using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Bookstore_Gallery___Checkout
{
    public partial class Form1 : Form
    {
        
        // Data Definitions 

        string[] BookTitles = {
            "CODE:The Hidden Language",
            "T-SQL Fundamentals",
            "The Object-Oriented",
            "Clean Code",
            "python",
            "RESTful API Design",
            "The C++ Programming Language",
            "Data Structures The Fun Way"
        };

        float[] BookPrices = {
            29.99f, 34.50f, 27.00f, 38.00f, 24.99f, 22.50f, 31.00f, 45.00f
        };

        string[] BookDescriptions = {
            "A unique journey into how computers work from hardware logic to modern software code.",
            "A comprehensive guide to mastering T-SQL querying and programming for SQL Server.",
            "An intuitive guide to understanding OOP concepts and object-oriented architecture.",
            "A handbook of agile software craftsmanship packed with principles for writing clean code.",
            "An introduction to programming fundamentals and practical problem-solving using Python.",
            "Master REST API design patterns, best practices, and enterprise integration techniques.",
            "The definitive C++ programming reference written by language creator Bjarne Stroustrup.",
            "An engaging and visual adventure to master core data structures and basic algorithms."
        };

        string[] BookImages = {
            "CODE.png",
            "T-SQL.png",
            "OOP.png",
            "Clean Code.png",
            "python.png",
            "Rwstful API_.png",
            "C++.png",
            "Data Structures The Fun Way.png"
        };

        // State Variables
        int CurrentBookIndex = 0;
        float TotalCartPrice = 0;
        HashSet<string> warnedMissingImages = new HashSet<string>();


        public Form1()
        {
            InitializeComponent();
            RegisterEvents();
        }

        void RegisterEvents()
        {
            this.Load -= Form1_Load;
            this.Load += Form1_Load;

            btnNext.Click -= btnNext_Click;
            btnNext.Click += btnNext_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            btnAddToCart.Click -= btnAddToCart_Click;
            btnAddToCart.Click += btnAddToCart_Click;

            btnRemove.Click -= btnRemove_Click;
            btnRemove.Click += btnRemove_Click;

            btnClose.Click -= btnClose_Click;
            btnClose.Click += btnClose_Click;
        }

        void SetupCartGrid()
        {
            gridCart.Rows.Clear();
            gridCart.Columns.Clear();

            gridCart.Columns.Add("colTitle", "Title");
            gridCart.Columns.Add("colQty", "Quantity");
            gridCart.Columns.Add("colPrice", "Price");
            gridCart.Columns.Add("colSubtotal", "Subtotal");

            gridCart.AllowUserToAddRows = false;
            gridCart.AllowUserToDeleteRows = false;
            gridCart.ReadOnly = true;
            gridCart.RowHeadersVisible = false;
            gridCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCart.MultiSelect = false;
            gridCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCart.DefaultCellStyle.ForeColor = Color.Black;
            gridCart.DefaultCellStyle.BackColor = Color.White;
            gridCart.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            gridCart.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        void UpdateNavigationButtons()
        {
            btnBack.Enabled = (CurrentBookIndex > 0);
            btnNext.Enabled = (CurrentBookIndex < BookTitles.Length - 1);
        }

        void UpdateBookInfoText()
        {
            lblTitle.Text = BookTitles[CurrentBookIndex];
            lblPrice.Text = "Price: $" + BookPrices[CurrentBookIndex].ToString("F2", CultureInfo.InvariantCulture);
            txtDescription.Text = BookDescriptions[CurrentBookIndex];
        }

        void UpdateBookImage()
        {
            if (picBookCover.Image != null)
            {
                picBookCover.Image.Dispose();
                picBookCover.Image = null;
            }

            string fileName = BookImages[CurrentBookIndex];
            List<string> triedPaths;
            string imagePath = FindImagePath(fileName, out triedPaths);

            if (imagePath != null)
            {
                try
                {
                    using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    using (Image temp = Image.FromStream(stream))
                    {
                        picBookCover.Image = new Bitmap(temp);
                    }
                }
                catch (Exception ex)
                {
                    picBookCover.Image = null;
                    MessageBox.Show("Could not open image:\n" + imagePath + "\n\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picBookCover.Image = null;

                if (warnedMissingImages.Add(fileName))
                {
                    MessageBox.Show("Image not found: " + fileName + "\n\nSearched in:\n" + string.Join("\n", triedPaths),
                        "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void UpdateBookDetails()
        {
            if (CurrentBookIndex < 0 || CurrentBookIndex >= BookTitles.Length)
                return;

            UpdateBookInfoText();
            UpdateBookImage();
            UpdateNavigationButtons();
        }
       
        DataGridViewRow FindCartRowByTitle(string title)
        {
            foreach (DataGridViewRow row in gridCart.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == title)
                {
                    return row;
                }
            }
            return null;
        }

        float CalculateCartTotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in gridCart.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string s = row.Cells[3].Value.ToString().Replace("$", "");
                    float sub;
                    if (float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out sub))
                    {
                        total += sub;
                    }
                }
            }
            return total;
        }

        void UpdateTotal()
        {
            TotalCartPrice = CalculateCartTotal();
            lblTotalCartPrice.Text = "Total: $" + TotalCartPrice.ToString("F2", CultureInfo.InvariantCulture);
        }

        void AddCurrentBookToCart()
        {
            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please select a quantity greater than zero!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = BookTitles[CurrentBookIndex];
            float price = BookPrices[CurrentBookIndex];

            DataGridViewRow existingRow = FindCartRowByTitle(title);

            if (existingRow != null)
            {
                int newQty = Convert.ToInt32(existingRow.Cells[1].Value) + quantity;
                existingRow.Cells[1].Value = newQty;
                existingRow.Cells[3].Value = "$" + (price * newQty).ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                float subtotal = price * quantity;
                gridCart.Rows.Add(
                    title,
                    quantity,
                    "$" + price.ToString("F2", CultureInfo.InvariantCulture),
                    "$" + subtotal.ToString("F2", CultureInfo.InvariantCulture)
                );
            }

            UpdateTotal();
            numQuantity.Value = 1;
            gridCart.ClearSelection();
        }

        void RemoveSelectedCartRow()
        {
            if (gridCart.CurrentRow == null)
            {
                MessageBox.Show("Please select a book from the cart first.", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            gridCart.Rows.Remove(gridCart.CurrentRow);
            UpdateTotal();
        }

        void ProcessCheckout()
        {
            if (gridCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add a book first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Order Confirmed", "Checkout",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                gridCart.Rows.Clear();
                UpdateTotal();
            }
        }

        string FindImagePath(string fileName, out List<string> triedPaths)
        {
            triedPaths = new List<string>();
            string startup = Application.StartupPath;

            string[] candidates = {
                Path.Combine(startup, "Images", fileName),
                Path.Combine(startup, "..", "..", "Images", fileName),
                Path.Combine(startup, "..", "..", "..", "Images", fileName),
                Path.Combine(Directory.GetCurrentDirectory(), "Images", fileName)
            };

            foreach (string c in candidates)
            {
                string full = Path.GetFullPath(c);
                triedPaths.Add(full);
                if (File.Exists(full))
                    return full;
            }

            return null;
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            SetupCartGrid();

            CurrentBookIndex = 0;
            UpdateBookDetails();
            UpdateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentBookIndex < BookTitles.Length - 1)
            {
                CurrentBookIndex++;
                UpdateBookDetails();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (CurrentBookIndex > 0)
            {
                CurrentBookIndex--;
                UpdateBookDetails();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddCurrentBookToCart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedCartRow();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProcessCheckout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}