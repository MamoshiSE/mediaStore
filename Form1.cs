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
    public partial class Form1 : Form   
    {
        List<Product> productsList = new List<Product>();
        BindingList<Order> soldProducts = new BindingList<Order>();
        BindingList<Order> filteredSoldProducts = new BindingList<Order>();
        
        double costOfProduct = 0;
        int count = 0;
        string productName = "";

        public Form1()
        {
            
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView2.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readCSV();
            readOrdersCSV();
            

        }

        private void titleMainScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void readOrdersCSV() // behövs i form 1
        {
            // read CSV file and store each line in array
            if (File.Exists("orders.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines("orders.csv");
                var productsIds = new List<string>(); // list of all product ids
              
                if (lines.Length > 0)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        // split each value in a line with ","
                        var values = lines[i].Split(',');
                        int OrderId = Int32.Parse(values[0]);
                        double TotalPrice = double.Parse(values[1]);
                        var products = values[2];
                        DateTime date = DateTime.Parse(values[3]);
                        
                        Order order = new Order(TotalPrice, products, OrderId, date);
                        soldProducts.Add(order);
                        
                       
                    }

                }
            }
        }

        private void readCSV()
        {
            
            // read CSV file and store each line in array
            if (File.Exists("products.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines("products.csv");
                int j = 0;
                if (lines.Length > 0 && j < 3)
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
                            productsList = productsList.OrderByDescending(o => o.Sold).ToList();  
                            productsList = productsList.Skip(0).Take(10).ToList();
                        
                    }
                }

                dataGridView1.DataSource = productsList;
                dataGridView1.Columns["quantity"].Visible = false;
                dataGridView1.Columns["media"].Visible = false;
                dataGridView1.Columns["productId"].Visible = false;

            }
        }

       

        private void button3_Click(object sender, EventArgs e)

        {
            filteredSoldProducts.Clear();
           costOfProduct = 0;
            count = 0;
           productName = "";
            int month = 0;
           
            if (searchProductId.Text != "" && searchProductYear.Text != "")
            {
                if (int.TryParse(searchProductId.Text, out _) == false)
                {
                    searchProductId.Clear();
                    MessageBox.Show("Please input only numbers for product id");

                }

                if (int.TryParse(searchProductYear.Text, out _) == false)
                {
                    searchProductYear.Clear();
                    MessageBox.Show("Please input only numbers for year");

                }
            
                for (int i = 0; i < soldProducts.Count; i++)
                {

                    if (comboBox1.SelectedIndex > -1)
                    {
                        month = comboBox1.SelectedIndex + 1;

                        if (soldProducts[i].Date.Year == Int32.Parse(searchProductYear.Text) && soldProducts[i].Date.Month == month)
                    {
                        filteredSoldProducts.Add(soldProducts[i]);
                            checkDateRange();
                    }
                } else if (soldProducts[i].Date.Year == Int32.Parse(searchProductYear.Text)) {
                        filteredSoldProducts.Add(soldProducts[i]);
                        checkDateRange();
                    }
                }
               
                

                costOfProduct = costOfProduct * count;
                dataGridView2.Rows.Clear();
                int rowIndex = this.dataGridView2.Rows.Add();
                var row = this.dataGridView2.Rows[rowIndex];
                row.Cells["Column1"].Value = searchProductId.Text;
                row.Cells["Column2"].Value = costOfProduct;
                row.Cells["Column3"].Value = searchProductYear.Text + " " + comboBox1.Text;
                row.Cells["Column4"].Value = productName;
                comboBox1.SelectedIndex = -1;
                


            } else
            {
                MessageBox.Show("Please input product ID and year of sales");

            }
        }

        private void checkDateRange()
        {
            
                for (int j = 0; j<filteredSoldProducts.Count; j++)
                {
                    
                    var productIds = filteredSoldProducts[j].Products.Split(';');
                    for (int k = 0; k<productIds.Length; k++)
                    {
                       
                        
                       

                        if (productIds[k] == searchProductId.Text)
                            
                        {
                            count++;
                            
                        }


}
                  
          
                }
                for (int i = 0; i<productsList.Count; i++)
                {
                    if (productsList[i].ProductId.ToString() == searchProductId.Text)
                    {

                        costOfProduct = productsList[i].Price;
                        productName = productsList[i].Name;


                    }
                }
        }

    }
}
