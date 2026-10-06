namespace Bookstore_Gallery___Checkout
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBookCatalog = new System.Windows.Forms.GroupBox();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.lblTotalCartPrice = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBookCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookCatalog
            // 
            this.grpBookCatalog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBookCatalog.Controls.Add(this.picBookCover);
            this.grpBookCatalog.Controls.Add(this.btnAddToCart);
            this.grpBookCatalog.Controls.Add(this.txtDescription);
            this.grpBookCatalog.Controls.Add(this.btnBack);
            this.grpBookCatalog.Controls.Add(this.numQuantity);
            this.grpBookCatalog.Controls.Add(this.btnNext);
            this.grpBookCatalog.Controls.Add(this.lblPrice);
            this.grpBookCatalog.Controls.Add(this.lblTitle);
            this.grpBookCatalog.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grpBookCatalog.Location = new System.Drawing.Point(26, 109);
            this.grpBookCatalog.Name = "grpBookCatalog";
            this.grpBookCatalog.Size = new System.Drawing.Size(318, 285);
            this.grpBookCatalog.TabIndex = 0;
            this.grpBookCatalog.TabStop = false;
            this.grpBookCatalog.Text = "Book Details";
            // 
            // picBookCover
            // 
            this.picBookCover.Image = ((System.Drawing.Image)(resources.GetObject("picBookCover.Image")));
            this.picBookCover.Location = new System.Drawing.Point(9, 43);
            this.picBookCover.Name = "picBookCover";
            this.picBookCover.Size = new System.Drawing.Size(100, 146);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookCover.TabIndex = 5;
            this.picBookCover.TabStop = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(99, 243);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(84, 23);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add to Cart ";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txtDescription.Location = new System.Drawing.Point(113, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(152, 87);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Book description will appear here";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(89, 205);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.Lavender;
            this.numQuantity.Location = new System.Drawing.Point(198, 205);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(33, 20);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(143, 205);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.lblPrice.Location = new System.Drawing.Point(113, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(92, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price: $0.00";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.lblTitle.Location = new System.Drawing.Point(115, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cartPanel.Controls.Add(this.lblTotalCartPrice);
            this.cartPanel.Controls.Add(this.btnCheckout);
            this.cartPanel.Controls.Add(this.btnRemove);
            this.cartPanel.Controls.Add(this.gridCart);
            this.cartPanel.Controls.Add(this.label1);
            this.cartPanel.ForeColor = System.Drawing.Color.White;
            this.cartPanel.Location = new System.Drawing.Point(350, 100);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(457, 294);
            this.cartPanel.TabIndex = 1;
            this.cartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cartPanel_Paint);
            // 
            // lblTotalCartPrice
            // 
            this.lblTotalCartPrice.AutoSize = true;
            this.lblTotalCartPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.lblTotalCartPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalCartPrice.Location = new System.Drawing.Point(316, 257);
            this.lblTotalCartPrice.Name = "lblTotalCartPrice";
            this.lblTotalCartPrice.Size = new System.Drawing.Size(89, 21);
            this.lblTotalCartPrice.TabIndex = 6;
            this.lblTotalCartPrice.Text = "Total Price$";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(3, 243);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 23);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(129, 243);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // gridCart
            // 
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCart.BackgroundColor = System.Drawing.Color.Lavender;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colQuantity,
            this.colPrice,
            this.colSubtotal});
            this.gridCart.GridColor = System.Drawing.Color.Black;
            this.gridCart.Location = new System.Drawing.Point(3, 33);
            this.gridCart.Name = "gridCart";
            this.gridCart.Size = new System.Drawing.Size(433, 204);
            this.gridCart.TabIndex = 1;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Cart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(74)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 50);
            this.panel1.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(16, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(25, 25);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rabar_042", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(787, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(47, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "BookStore";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(26, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 30);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(77, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartPanel);
            this.Controls.Add(this.grpBookCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpBookCatalog.ResumeLayout(false);
            this.grpBookCatalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.cartPanel.ResumeLayout(false);
            this.cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBookCatalog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotalCartPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.PictureBox picBookCover;
    }
}

