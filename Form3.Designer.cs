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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addToCart = new System.Windows.Forms.Button();
            this.guideText = new System.Windows.Forms.TextBox();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmSell = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.removeFromCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 62);
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
            this.addToCart.Location = new System.Drawing.Point(54, 180);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(75, 32);
            this.addToCart.TabIndex = 24;
            this.addToCart.Text = "Sell";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.button2_Click);
            // 
            // guideText
            // 
            this.guideText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.guideText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.guideText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guideText.CausesValidation = false;
            this.guideText.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideText.ForeColor = System.Drawing.SystemColors.Window;
            this.guideText.Location = new System.Drawing.Point(13, 62);
            this.guideText.Multiline = true;
            this.guideText.Name = "guideText";
            this.guideText.ReadOnly = true;
            this.guideText.Size = new System.Drawing.Size(152, 106);
            this.guideText.TabIndex = 22;
            this.guideText.TabStop = false;
            this.guideText.Text = "     *Note                   Click on sell button to add marked item to customers" +
    " cart.";
            this.guideText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guideText.TextChanged += new System.EventHandler(this.guideText_TextChanged);
            // 
            // productInventory
            // 
            this.productInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.productInventory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.productInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productInventory.CausesValidation = false;
            this.productInventory.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.productInventory.Location = new System.Drawing.Point(312, 22);
            this.productInventory.Name = "productInventory";
            this.productInventory.ReadOnly = true;
            this.productInventory.Size = new System.Drawing.Size(309, 34);
            this.productInventory.TabIndex = 25;
            this.productInventory.TabStop = false;
            this.productInventory.Text = "Available products for sale";
            this.productInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(263, 272);
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
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CausesValidation = false;
            this.textBox2.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(13, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 106);
            this.textBox2.TabIndex = 27;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "     *Note                   Click on sell button to add marked item to customers" +
    " cart.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(248, 312);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(389, 150);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 534);
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
            this.Text = "Form3";
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
    }
}