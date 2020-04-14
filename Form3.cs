using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaStore
{
    public partial class Form3 : Form
    {
        BindingList<Product> productsList = new BindingList<Product>();
        BindingList<Product> customerCart = new BindingList<Product>();
        public Form3()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView2.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            readCSV();
            dataGridView2.DataSource = customerCart;
            dataGridView2.Columns["quantity"].Visible = false;
            dataGridView2.Columns["media"].Visible = false;
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
                        Product product = new Product(name, price, id, media, quantity);
                        productsList.Add(new Product(name, price, id, media, quantity));




                        System.Console.WriteLine(product.Name);
                    }




                }

                dataGridView1.DataSource = productsList;
                

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

        private void guideText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    var rowIndex = dataGridView1.CurrentCell.RowIndex;
                    if (productsList[rowIndex].Quantity > 0)
                    {
                        
                        productsList[rowIndex].Quantity -= 1;
                        productsList.ResetBindings();
                        updateCSV();
                        customerCart.Add(productsList[rowIndex]);
                    } else
                    {
                        MessageBox.Show("This product is sold out.");
                    }


                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Exception thrown", ex);
                }
            }
            else
            {
                MessageBox.Show("Select the row or a cell inside the row you want to sell.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                try
                {
                    var rowIndex = dataGridView2.CurrentCell.RowIndex;
 
                       
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        if (customerCart[rowIndex].ProductId == productsList[i].ProductId)
                        {
                            productsList[i].Quantity += 1;
                            productsList.ResetBindings();
                            updateCSV();
                        }
                    }
                    customerCart.RemoveAt(rowIndex);



                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Exception thrown", ex);
                }
            }
            else
            {
                MessageBox.Show("Select the row or a cell inside the row you want to remove from cart.");
            }
        }
    }
}
