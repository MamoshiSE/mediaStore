namespace mediaStore
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addProduct = new System.Windows.Forms.Button();
            this.productMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleStoremenScreen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.productMedia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.productQuantity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.productId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.productPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.titleStoremenScreen);
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(164, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 241);
            this.panel1.TabIndex = 0;
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProduct.Location = new System.Drawing.Point(239, 174);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 32);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // productMedia
            // 
            this.productMedia.Location = new System.Drawing.Point(141, 124);
            this.productMedia.Name = "productMedia";
            this.productMedia.Size = new System.Drawing.Size(117, 20);
            this.productMedia.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Media:";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(367, 124);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(73, 20);
            this.productQuantity.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantity:";
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(406, 72);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(117, 20);
            this.productId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product ID:";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(239, 72);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(73, 20);
            this.productPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(53, 72);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(117, 20);
            this.productName.TabIndex = 11;
            this.productName.TextChanged += new System.EventHandler(this.drawAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleStoremenScreen
            // 
            this.titleStoremenScreen.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.titleStoremenScreen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titleStoremenScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleStoremenScreen.CausesValidation = false;
            this.titleStoremenScreen.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleStoremenScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.titleStoremenScreen.Location = new System.Drawing.Point(131, 15);
            this.titleStoremenScreen.Name = "titleStoremenScreen";
            this.titleStoremenScreen.ReadOnly = true;
            this.titleStoremenScreen.Size = new System.Drawing.Size(309, 34);
            this.titleStoremenScreen.TabIndex = 2;
            this.titleStoremenScreen.TabStop = false;
            this.titleStoremenScreen.Text = "Add new product";
            this.titleStoremenScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleStoremenScreen.TextChanged += new System.EventHandler(this.titleMainScreen_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(913, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titleStoremenScreen;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}