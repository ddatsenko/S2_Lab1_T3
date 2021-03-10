using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Lab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) pictureBox1.BackColor = Color.Green;
            else pictureBox1.BackColor = Color.FromName(listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }
    }
}
