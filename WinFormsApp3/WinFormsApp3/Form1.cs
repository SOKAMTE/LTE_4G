using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vous")
            {
                if (textBox2.Text == "Mot de Passe")
                {
                    forme2 f = new forme2();
                    f.show();
                    this.Hide(); // pour cacher l'interface d'authentification
                }
                else
                    label3.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    private void Auth_Enter(object sender,
                            EventArgs e)
    {

    }
}

internal class forme2
{
    internal void show()
    {
        throw new NotImplementedException();
    }
}