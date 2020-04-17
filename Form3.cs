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
        double totalCost;
        public Form3()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView2.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            searchTitle.BackColor = ColorTranslator.FromHtml("#0f1923");
            searchMediaTitle.BackColor = ColorTranslator.FromHtml("#0f1923");
            searchFilterTitle.BackColor = ColorTranslator.FromHtml("#0f1923");
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            readCSV();
            dataGridView2.DataSource = customerCart;
            dataGridView1.Columns["sold"].Visible = false;
            dataGridView2.Columns["quantity"].Visible = false;
            dataGridView2.Columns["media"].Visible = false;
            dataGridView2.Columns["sold"].Visible = false;
            comboBox1.SelectedIndex = 0;
           
           


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
                      
                        
                        customerCart.Add(productsList[rowIndex]);
                        totalCartCost();

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

     

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            BindingList<Product> filtered = new BindingList<Product>(productsList.Where(obj => obj.Name.ToUpper().Contains(searchBox.Text.ToUpper())).ToList());
         
            
             dataGridView1.DataSource = filtered;
             dataGridView1.Update();
        
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableFilter();
        }

        private void availableFilter()
        {
            try
            {

              
                if (comboBox1.SelectedItem.ToString() == "Available" )
                {
                   
                    BindingList<Product> filtered = new BindingList<Product>(productsList.Where(obj => obj.Quantity > 0).ToList());


                    dataGridView1.DataSource = filtered;
                    dataGridView1.Update();
                } else if (comboBox1.SelectedItem.ToString() == "Unavailable")
                {
                    BindingList<Product> filtered = new BindingList<Product>(productsList.Where(obj => obj.Quantity == 0).ToList());
                    dataGridView1.DataSource = filtered;
                    dataGridView1.Update();
                } else
                {
                    dataGridView1.DataSource = productsList;
                    dataGridView1.Update();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Exception thrown", ex);
            }
        }

       

        private void searchMediaBox_TextChanged(object sender, EventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(productsList.Where(obj => obj.Media.ToUpper().Contains(searchMediaBox.Text.ToUpper())).ToList());
            

            dataGridView1.DataSource = filtered;
            dataGridView1.Update();
        }

        private void totalCartCost()
        {
            totalCost = 0;
            if(customerCart.Count > 0)
            {
                for(int i = 0; i < customerCart.Count; i++)
                {
                    totalCost += customerCart[i].Price;
                }
                
            }
            totalCostBox.Text = totalCost.ToString() + " SEK";
        }

      

        private void confirmSell_Click(object sender, EventArgs e)
        {
            // adding all ids of a sold product in 1 order
            string productIds = "";
            int linesCount = 0;
            int index = 0;
            // order id increments by 1 for each existing receipt
            if (File.Exists("orders.csv")) { 
                 linesCount = System.IO.File.ReadAllLines("orders.csv").Count();
        } 
            if (customerCart.Count > 0)
            {
                for (int i = 0; i < customerCart.Count; i++)
                {
                    productIds += customerCart[i].ProductId + ";";
                }
                Order orders = new Order(totalCost, productIds, linesCount + 1);
                writeOrdersToCSV(orders);

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    customerCart[index].Sold += 1;
                    index++;

                }
               
                DialogResult dialogResult = MessageBox.Show("Do you want to print out a receipt?", "Sale receipt", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }

                }

                productsList.ResetBindings();
                customerCart.Clear();
                updateCSV();
                totalCostBox.Text = "0";

            } else
            {
                MessageBox.Show("There is no items in the cart.");
            }
           
        }

        private void writeOrdersToCSV(Order orders)
        {
            
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("orders.csv", true))
                {
                    file.WriteLine(orders.OrderId + "," + orders.TotalPrice + "," + orders.Products + "," + orders.date);
                }


            }
            catch (Exception ex)
            {
                throw new ApplicationException("Exception thrown", ex);
            }
        }


     
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void returnItem_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    try
                    {
                        var rowIndex = dataGridView1.CurrentCell.RowIndex;
                       

                            

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to return " + productsList[rowIndex].Name + " for " + productsList[rowIndex].Price + " SEK?", "Item return", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            productsList[rowIndex].Quantity += 1;
                            productsList.ResetBindings();
                            updateCSV();

                        }


                    }
                        


                    
                    catch (Exception ex)
                    {
                        throw new ApplicationException("Exception thrown", ex);
                    }
                }
                else
                {
                    MessageBox.Show("Select the row or a cell inside the row of the product you want to return.");
                }
            }
        }
    }
}
