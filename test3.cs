using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class test3 : Form
    {
        Random rnd = new Random();
        int numar1, numar2, i;
        public test3()
        {
            InitializeComponent();
        }
        
        void verificare_index()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("plus.png");
                numar1 = rnd.Next(1, 11);
                numar2 = rnd.Next(1, 11);
                richTextBox1.Text = "" + numar1;
                richTextBox2.Text = "" + numar2;
                i = 0;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("minus.png");
                numar1 = rnd.Next(1, 11);
                numar2 = rnd.Next(1, 11);
                int aux;
                if (numar1 < numar2)
                {
                    aux = numar2;
                    numar2 = numar1;
                    numar1 = aux;
                    richTextBox1.Text = "" + numar1;
                    richTextBox2.Text = "" + numar2;
                }
                else
                {
                    richTextBox1.Text = "" + numar1;
                    richTextBox2.Text = "" + numar2;
                }
                i = 1;

            }

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("ori.png");
                numar1 = rnd.Next(1, 11);
                numar2 = rnd.Next(1, 11);
                richTextBox1.Text = "" + numar1;
                richTextBox2.Text = "" + numar2;
                i = 2;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("impartit.png");
                numar1 = rnd.Next(1, 11);
                numar2 = rnd.Next(1, 11);
                numar1 = numar1 * numar2;
                richTextBox1.Text = "" + numar1;
                richTextBox2.Text = "" + numar2;
                i = 3;
            }
        }
        void verificare()
        {
            if (i==0)
            {
                if (richTextBox3.Text == "" + (numar1 + numar2))
                {
                    richTextBox3.Text = "";
                    numar1 = rnd.Next(1, 11);
                    numar2 = rnd.Next(1, 11);
                    richTextBox1.Text = "" + numar1;
                    richTextBox2.Text = "" + numar2;
                }
                else
                { MessageBox.Show("Raspuns gresit!"); }
            }

             if (i==1)
                {
                    if (richTextBox3.Text == "" + (numar1-numar2))
                    {
                        richTextBox3.Text = "";
                        numar1 = rnd.Next(1, 11);
                        numar2 = rnd.Next(1, 11);
                        int aux;
                        if (numar1 < numar2)
                        {
                            aux = numar2;
                            numar2 = numar1;
                            numar1 = aux;
                            richTextBox1.Text = "" + numar1;
                            richTextBox2.Text = "" + numar2;
                        }
                        else
                        {
                            richTextBox1.Text = "" + numar1;
                            richTextBox2.Text = "" + numar2;
                        }
                    }
                    else
                    { MessageBox.Show("Raspuns gresit!"); }
                }

             if (i == 2)
                {
                    if (richTextBox3.Text == "" + numar1 * numar2)
                    {
                        richTextBox3.Text = "";
                        numar1 = rnd.Next(1, 11);
                        numar2 = rnd.Next(1, 11);
                        richTextBox1.Text = "" + numar1;
                        richTextBox2.Text = "" + numar2;
                    }
                    else
                    { MessageBox.Show("Raspuns gresit!"); }
                }

              if (i == 3)
                {  
                  if (richTextBox3.Text == "" + numar1 / numar2)
                    {
                        richTextBox3.Text = "";
                        numar1 = rnd.Next(1, 11);
                        numar2 = rnd.Next(1, 11);
                        numar1 = numar1 * numar2;
                        richTextBox1.Text = "" + numar1;
                        richTextBox2.Text = "" + numar2;
                    }
                    else
                    { MessageBox.Show("Raspuns gresit!"); }
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            verificare();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificare_index();
        }

    }
}
