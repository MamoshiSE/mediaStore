using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            titleStoremenScreen.BackColor = ColorTranslator.FromHtml("#0f1923");

         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void titleMainScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void drawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productName.Text == "" || productPrice.Text == "" || productId.Text == "" || productMedia.Text == "" ||
               productQuantity.Text == "")
            {
              
                MessageBox.Show("Please fill in all input fields");
            }
            else
            {
                string name = productName.Text;
                double price = double.Parse(productPrice.Text);
                int id = Int32.Parse(productId.Text);
                string media = productMedia.Text;
                int quantity = Int32.Parse(productQuantity.Text);
                Product product = new Product(name, price, id, media, quantity);
                //  MessageBox.Show(product.Name);

                //  List<Product> productsList = new List<Product>();
                //productsList.Add(new Product(name, price, id, media, quantity));
                writeToCSV(product);
            }
        }

        private void writeToCSV(Product product)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("products.csv", true))
                {
                    file.WriteLine(product.Name + "," + product.Price + "," + product.ProductId + "," + product.Media + "," + product.Quantity);
                }
            } catch(Exception ex)
            {
                throw new ApplicationException("Exception thrown", ex);
            }
            }

          
        }
    }

