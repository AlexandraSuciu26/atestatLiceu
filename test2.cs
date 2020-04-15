using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace atestat
{
    public partial class test2 : Form
    {
        public test2()
        {
            InitializeComponent();
            citire("test2.txt");
            afisare();
        }

        string s;
        string[] si = new string[50];
        string[] sr = new string[50];
        int[] v = new int[50];
        int nr, nr1 = 0, k, i, rasp_corect = 0, intreb_total = 0;
        Random ran = new Random();

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void citire(string fisier)
        {
            StreamReader st = new StreamReader(fisier);
            i = nr = 0;
            while ((s = st.ReadLine()) != null)
            {
                if (i == 0)
                    si[nr] = s;
                if (i == 1)
                {
                    sr[nr] = s;
                    nr++;
                    i = 0;
                }
                else i++;
            }
            st.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && sr[k] == "a")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (comboBox1.SelectedIndex == 1 && sr[k] == "b")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (comboBox1.SelectedIndex == 2 && sr[k] == "c")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (comboBox1.SelectedIndex == 3 && sr[k] == "d")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (comboBox1.SelectedIndex == 0 && sr[k] != "a")
            {

                groupBox1.Text = "Gresit!";
            }
            if (comboBox1.SelectedIndex == 1 && sr[k] != "b")
            {

                groupBox1.Text = "Gresit!";
            }
            if (comboBox1.SelectedIndex == 2 && sr[k] != "c")
            {

                groupBox1.Text = "Gresit!";
            }

            if (comboBox1.SelectedIndex == 3 && sr[k] != "d")
            {

                groupBox1.Text = "Gresit!";
            }
            
            button2.Visible = true;
        }
        void afisare()
        {
            int i, ok;
            if (nr1 < nr)
            {

                do
                {
                    ok = 0;
                    k = ran.Next(0, nr);
                    for (i = 0; i < nr1; i++)
                        if (v[i] == k) ok = 1;
                } while (ok == 1);
                v[nr1] = k;
                nr1++;
                pictureBox1.Image = Image.FromFile(si[k]);
                groupBox1.Text = null;
                button2.Visible = false;
            }
            else
            {
                s = "Total " + Convert.ToString(nr1) + " intrebari \n Corecte= " + Convert.ToString(rasp_corect);
                MessageBox.Show(s);
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            afisare();
        }


        
    }
}
