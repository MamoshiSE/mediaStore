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
        List<Product> productsList = new List<Product>();
        public Form2()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            titleStoremenScreen.BackColor = ColorTranslator.FromHtml("#0f1923");
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // read CSV file and store each line in array
            string[] lines = System.IO.File.ReadAllLines("products.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                // split each value in a line with ","
                var values = lines[i].Split(',');
                string name = values[0];
                double price = double.Parse(values[1]);
                int id = Int32.Parse(values[2]);
                string media = values[3];
                int quantity = Int32.Parse(values[4]);
                Product product = new Product(name, price, id, media, quantity);
                productsList.Add(new Product(name, price, id, media, quantity));
                System.Console.WriteLine(product.Name);
            }
               
          
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
                productsList.Add(new Product(name, price, id, media, quantity));
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

