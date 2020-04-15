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
        public Form1()
        {
            
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#0f1923");
            titleMainScreen.BackColor = ColorTranslator.FromHtml("#0f1923");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
