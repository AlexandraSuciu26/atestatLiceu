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
    public partial class test1 : Form
    {
        string s;
        string[] si = new string[50];
        string[] sa = new string[50];
        string[] sb = new string[50];
        string[] sc = new string[50];
        string[] sd = new string[50];
        string[] sr = new string[50];
        Random ran = new Random();
        int[] v = new int[50];
        int nr, nr1=0, k, i, rasp_corect = 0, intreb_total = 0;

       

        private void button2_Click(object sender, EventArgs e)
        {
            afisare();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true&&sr[k]=="a")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (radioButton2.Checked == true && sr[k] == "b")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (radioButton3.Checked == true && sr[k] == "c")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (radioButton4.Checked == true && sr[k] == "d")
            {
                rasp_corect++;
                groupBox1.Text = "Corect!";
            }
            if (radioButton1.Checked == true && sr[k] != "a")
            {
                
                groupBox1.Text = "Gresit!";
            }
            if (radioButton2.Checked == true && sr[k] != "b")
            {

                groupBox1.Text = "Gresit!";
            }
            if (radioButton3.Checked == true && sr[k] != "c")
            {

                groupBox1.Text = "Gresit!";
            }

            if (radioButton4.Checked == true && sr[k] != "d")
            {

                groupBox1.Text = "Gresit!";
            }
            button1.Visible = false;
            button2.Visible = true;
        }

        public test1()
        {
            InitializeComponent();
            citire("test1.txt");
            afisare();
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
                    sa[nr] = s;
                if (i == 2)
                    sb[nr] = s;
                if (i == 3)
                    sc[nr] = s;
                if (i == 4)
                    sd[nr] = s;
                if (i == 5)
                {
                    sr[nr] = s;
                    nr++;
                    i = 0;
                }
                else i++;
            }
            st.Close();
        }

        void afisare()
        {
            int i, ok;
            if (nr1 < nr )
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
                pictureBox2.Image = Image.FromFile(sa[k]);
                pictureBox3.Image = Image.FromFile(sb[k]);
                pictureBox4.Image = Image.FromFile(sc[k]);
                pictureBox5.Image = Image.FromFile(sd[k]);
                radioButton5.Checked = true;
                groupBox1.Text = null;
                button1.Visible = true;
                button2.Visible = false;
            }
            else
            {
                s = "Total " + Convert.ToString(nr1) + " intrebari \n Corecte= " + Convert.ToString(rasp_corect);
                MessageBox.Show(s);
                this.Close();
            }
            
        }
    }
}

