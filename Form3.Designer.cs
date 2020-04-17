namespace mediaStore
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addToCart = new System.Windows.Forms.Button();
            this.guideText = new System.Windows.Forms.TextBox();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmSell = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.removeFromCart = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchTitle = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchFilterTitle = new System.Windows.Forms.TextBox();
            this.searchMediaTitle = new System.Windows.Forms.TextBox();
            this.searchMediaBox = new System.Windows.Forms.TextBox();
            this.totalCostBox = new System.Windows.Forms.TextBox();
            this.totalCostTitle = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.returnItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(587, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // addToCart
            // 
            this.addToCart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToCart.Location = new System.Drawing.Point(5, 218);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(78, 32);
            this.addToCart.TabIndex = 24;
            this.addToCart.Text = "Sell Item";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.button2_Click);
            // 
            // guideText
            // 
            this.guideText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.guideText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guideText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guideText.CausesValidation = false;
            this.guideText.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideText.ForeColor = System.Drawing.SystemColors.Window;
            this.guideText.Location = new System.Drawing.Point(12, 22);
            this.guideText.Multiline = true;
            this.guideText.Name = "guideText";
            this.guideText.ReadOnly = true;
            this.guideText.Size = new System.Drawing.Size(152, 190);
            this.guideText.TabIndex = 22;
            this.guideText.TabStop = false;
            this.guideText.Text = "*Note\r\nClick on sell item button to add marked item to customers cart.  \r\nClick o" +
    "n return item button to return a customer product to inventory.";
            this.guideText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productInventory
            // 
            this.productInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.productInventory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.productInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productInventory.CausesValidation = false;
            this.productInventory.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.productInventory.Location = new System.Drawing.Point(285, 22);
            this.productInventory.Name = "productInventory";
            this.productInventory.ReadOnly = true;
            this.productInventory.Size = new System.Drawing.Size(367, 34);
            this.productInventory.TabIndex = 25;
            this.productInventory.TabStop = false;
            this.productInventory.Text = "Available products for sale/return";
            this.productInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(264, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 34);
            this.textBox1.TabIndex = 29;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Customer cart";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmSell
            // 
            this.confirmSell.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmSell.Location = new System.Drawing.Point(685, 479);
            this.confirmSell.Name = "confirmSell";
            this.confirmSell.Size = new System.Drawing.Size(75, 32);
            this.confirmSell.TabIndex = 28;
            this.confirmSell.Text = "Confirm sale";
            this.confirmSell.UseVisualStyleBackColor = false;
            this.confirmSell.Click += new System.EventHandler(this.confirmSell_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CausesValidation = false;
            this.textBox2.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(13, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 174);
            this.textBox2.TabIndex = 27;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "     *Note      Confirm sale button sells everything in the list and remove item " +
    "moves back the product on the selected row to the inventory.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(248, 323);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(389, 150);
            this.dataGridView2.TabIndex = 26;
            // 
            // removeFromCart
            // 
            this.removeFromCart.BackColor = System.Drawing.Color.DarkRed;
            this.removeFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeFromCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeFromCart.Location = new System.Drawing.Point(601, 479);
            this.removeFromCart.Name = "removeFromCart";
            this.removeFromCart.Size = new System.Drawing.Size(78, 32);
            this.removeFromCart.TabIndex = 30;
            this.removeFromCart.Text = "Remove item";
            this.removeFromCart.UseVisualStyleBackColor = false;
            this.removeFromCart.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(585, 248);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(137, 20);
            this.searchBox.TabIndex = 32;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchTitle
            // 
            this.searchTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.searchTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTitle.CausesValidation = false;
            this.searchTitle.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.searchTitle.Location = new System.Drawing.Point(554, 218);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.ReadOnly = true;
            this.searchTitle.Size = new System.Drawing.Size(189, 24);
            this.searchTitle.TabIndex = 33;
            this.searchTitle.TabStop = false;
            this.searchTitle.Text = "Search by product name";
            this.searchTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Available",
            "Unavailable"});
            this.comboBox1.Location = new System.Drawing.Point(173, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchFilterTitle
            // 
            this.searchFilterTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.searchFilterTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchFilterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchFilterTitle.CausesValidation = false;
            this.searchFilterTitle.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFilterTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.searchFilterTitle.Location = new System.Drawing.Point(173, 218);
            this.searchFilterTitle.Name = "searchFilterTitle";
            this.searchFilterTitle.ReadOnly = true;
            this.searchFilterTitle.Size = new System.Drawing.Size(121, 24);
            this.searchFilterTitle.TabIndex = 35;
            this.searchFilterTitle.TabStop = false;
            this.searchFilterTitle.Text = "Filter";
            this.searchFilterTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchMediaTitle
            // 
            this.searchMediaTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.searchMediaTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchMediaTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchMediaTitle.CausesValidation = false;
            this.searchMediaTitle.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMediaTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.searchMediaTitle.Location = new System.Drawing.Point(326, 218);
            this.searchMediaTitle.Name = "searchMediaTitle";
            this.searchMediaTitle.ReadOnly = true;
            this.searchMediaTitle.Size = new System.Drawing.Size(190, 24);
            this.searchMediaTitle.TabIndex = 37;
            this.searchMediaTitle.TabStop = false;
            this.searchMediaTitle.Text = "Search by media type";
            this.searchMediaTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchMediaBox
            // 
            this.searchMediaBox.Location = new System.Drawing.Point(358, 248);
            this.searchMediaBox.Name = "searchMediaBox";
            this.searchMediaBox.Size = new System.Drawing.Size(137, 20);
            this.searchMediaBox.TabIndex = 36;
            this.searchMediaBox.TextChanged += new System.EventHandler(this.searchMediaBox_TextChanged);
            // 
            // totalCostBox
            // 
            this.totalCostBox.Enabled = false;
            this.totalCostBox.Location = new System.Drawing.Point(643, 453);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.ReadOnly = true;
            this.totalCostBox.Size = new System.Drawing.Size(100, 20);
            this.totalCostBox.TabIndex = 38;
            // 
            // totalCostTitle
            // 
            this.totalCostTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.totalCostTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalCostTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCostTitle.CausesValidation = false;
            this.totalCostTitle.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.totalCostTitle.Location = new System.Drawing.Point(643, 423);
            this.totalCostTitle.Name = "totalCostTitle";
            this.totalCostTitle.ReadOnly = true;
            this.totalCostTitle.Size = new System.Drawing.Size(100, 24);
            this.totalCostTitle.TabIndex = 39;
            this.totalCostTitle.TabStop = false;
            this.totalCostTitle.Text = "Total cost:";
            this.totalCostTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // returnItem
            // 
            this.returnItem.BackColor = System.Drawing.Color.DarkRed;
            this.returnItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnItem.Location = new System.Drawing.Point(86, 218);
            this.returnItem.Name = "returnItem";
            this.returnItem.Size = new System.Drawing.Size(78, 32);
            this.returnItem.TabIndex = 40;
            this.returnItem.Text = "Return Item";
            this.returnItem.UseVisualStyleBackColor = false;
            this.returnItem.Click += new System.EventHandler(this.returnItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.returnItem);
            this.Controls.Add(this.totalCostTitle);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.searchMediaTitle);
            this.Controls.Add(this.searchMediaBox);
            this.Controls.Add(this.searchFilterTitle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.removeFromCart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmSell);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.productInventory);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.guideText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Cashier - Management";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.TextBox guideText;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button confirmSell;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button removeFromCart;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox searchTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchFilterTitle;
        private System.Windows.Forms.TextBox searchMediaTitle;
        private System.Windows.Forms.TextBox searchMediaBox;
        private System.Windows.Forms.TextBox totalCostBox;
        private System.Windows.Forms.TextBox totalCostTitle;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button returnItem;
    }
}