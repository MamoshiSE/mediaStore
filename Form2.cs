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
        BindingList<Product> productsList = new BindingList<Product>();
        public Form2()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            readCSV();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (productName.Text == "" || productPrice.Text == "" || productId.Text == "" || productMedia.Text == "" ||
               productQuantity.Text == "")
            {
              
                MessageBox.Show("Please fill in all input fields");
            }
            else if (int.TryParse(productId.Text, out _) == false)
            {

                MessageBox.Show("Please input only numbers for product id");

            }
            else if (int.TryParse(productQuantity.Text, out _) == false)
            {

                MessageBox.Show("Please input only numbers for product quantity");

            }
            else if (double.TryParse(productPrice.Text, out _) == false)
            {

                MessageBox.Show("Please input only numbers for product price");

            }

            else if (checkProductId(productId.Text) == true){
                MessageBox.Show("Product ID already exists.");
            } 
                else
            {
                string name = productName.Text;
                double price = double.Parse(productPrice.Text);
                int id = Int32.Parse(productId.Text);
                string media = productMedia.Text;
                int quantity = Int32.Parse(productQuantity.Text);
                int sold = 0;
                Product product = new Product(name, price, id, media, quantity, sold);
                productsList.Add(new Product(name, price, id, media, quantity, sold));
                 if (File.Exists("products.csv"))
                  {
                      writeToCSV(product);

                  } else
                  {
                      writeToCSV(product);
                    productsList.Clear();
                      readCSV();
                  }
            }
        }

        private void writeToCSV(Product product)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("products.csv", true))
                {
                    file.WriteLine(product.Name + "," + product.Price + "," + product.ProductId + "," + product.Media + "," + product.Quantity + "," + product.Sold);
                }
              
         
            } catch(Exception ex)
            {
                throw new ApplicationException("Exception thrown", ex);
            }
            }

        private void readCSV()
        {
            // read CSV file and store each line in array
            if (File.Exists("products.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines("products.csv");
                if (lines.Length > 0)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        // split each value in a line with ","
                        var values = lines[i].Split(',');
                        string name = values[0];
                        double price = double.Parse(values[1]);
                        int id = Int32.Parse(values[2]);
                        string media = values[3];
                        int quantity = Int32.Parse(values[4]);
                        int sold = Int32.Parse(values[5]);
                        Product product = new Product(name, price, id, media, quantity, sold);
                        productsList.Add(new Product(name, price, id, media, quantity, sold));
                    }
                }

                dataGridView1.DataSource = productsList;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns["sold"].Visible = false;

            }
        }

        private void updateCSV()
        {
            try
            {
                var sb = new StringBuilder();
             
                {
                   

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        
                        var cells = row.Cells.Cast<DataGridViewCell>();
                      
                        sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
                     
                    }

                    System.IO.File.WriteAllText("products.csv", sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Exception thrown", ex);
            }
        }

        private bool checkProductId(String product)
        {

            

                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].ProductId == Int32.Parse(product))
                    {
                        return true;
                    }
                }

          

            
            
            return false;
        }

    
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            updateCSV();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    var rowIndex = dataGridView1.CurrentCell.RowIndex;
                    if (productsList[rowIndex].Quantity < 1)
                    {
                        dataGridView1.DataSource = null;
                        productsList.RemoveAt(rowIndex);
                        dataGridView1.DataSource = productsList;
                        updateCSV();
                    } else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this product from inventory?", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            dataGridView1.DataSource = null;
                            productsList.RemoveAt(rowIndex);
                            dataGridView1.DataSource = productsList;
                            updateCSV();
                        }
                       
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Exception thrown", ex);
                }
            } else
            {
                MessageBox.Show("Select the row or a cell inside the row you want to remove.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    var rowIndex = dataGridView1.CurrentCell.RowIndex;
                    productsList[rowIndex].Quantity += 1;
                    productsList.ResetBindings();
                       updateCSV();
                   
                   
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Exception thrown", ex);
                }
            }
            else
            {
                MessageBox.Show("Select the row or a cell inside the row you increase quantity of.");
            }
        }
    }
    }

