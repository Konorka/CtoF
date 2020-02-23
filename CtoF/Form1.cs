using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtoF
{
    public partial class Form1 : Form
    {
        double celsius;
        double fahrenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBoxC.Text, out double C))
            {
                celsius = C;
                fahrenheit = celsius * 1.8 + 32;
                this.textBoxF.Text = fahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Kérmen számot írjon", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxC.Text = "";
            }

        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxF.Text, out double F) || textBoxC.Text.StartsWith("-"))
            {
                fahrenheit = F;
                celsius = Math.Round((fahrenheit - 32) / 1.8, 2);
                this.textBoxC.Text = celsius.ToString();

            }
            else
            {
                MessageBox.Show("Kérmen számot írjon", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxF.Text = "";
            }

        }
    }
}
