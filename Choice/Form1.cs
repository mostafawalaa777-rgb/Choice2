using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Choice.Properties;

namespace Choice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
           label1.Text = ((RadioButton)sender).Tag.ToString();     }

        private void Pb2Girl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            label1.Text = ((RadioButton)sender).Tag.ToString();
        }
        private void Pb3Pen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;

             label1.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void PbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            label1.Text =((RadioButton)sender ).Tag.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image= Resources.Book;
                    label2.Text = "Book";
                    break;

                case 1:
                    pictureBox2.Image = Resources.Pen;
                    label2.Text = "Pen";
                    break;

                case 2:
                    pictureBox2.Image = Resources.Boy;
                    label2.Text = "Boy";
                    break;

                case 3:
                    pictureBox2.Image = Resources.Girl;
                    label2.Text = "Girl";
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
