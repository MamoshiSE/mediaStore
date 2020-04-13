﻿using System;
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
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#0f1923");
            guideText.BackColor = ColorTranslator.FromHtml("#1b2733");
            productInventory.BackColor = ColorTranslator.FromHtml("#0f1923");


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            // read CSV file and store each line in array
            if (File.Exists("products.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines("products.csv");
                for (int i = 0; i < lines.Length - 1; i++)
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
                dataGridView1.DataSource = productsList;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
             /*   var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Insert(5, deleteButton);*/
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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productsList;
                writeToCSV(product);
                // reset datagridview so it updates in realtime and reassign
                 
               
               
                

               
               
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    dataGridView1.DataSource = null;
                    productsList.RemoveAt(rowIndex);
                    dataGridView1.DataSource = productsList;
                    updateCSV();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

