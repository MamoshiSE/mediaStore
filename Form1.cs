using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
