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
        public Form1()
        {
            
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readCSV();
            
            dataGridView1.Columns["quantity"].Visible = false;
            dataGridView1.Columns["media"].Visible = false;
            dataGridView1.Columns["productId"].Visible = false;
           
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
                        var productIds = values[2].Split(';');

                        for (int j = 0; j < productIds.Length; j++)
                        {
                            productsIds.Add(productIds[j]);
                            System.Console.WriteLine(productIds[j]);

                        }

                        string date = values[3];
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


            }
        }

       

     
    }
}
