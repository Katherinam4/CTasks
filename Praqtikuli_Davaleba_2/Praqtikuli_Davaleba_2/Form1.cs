using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praqtikuli_Davaleba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fudze, simagle;
            int fart_mart;

            fudze = int.Parse(textBox1.Text);
            simagle = int.Parse(textBox2.Text);


            Martkutxedi obj_mart = new Martkutxedi(fudze, simagle);
            fart_mart = obj_mart.Fart_Mart();

            label4.Text = fart_mart.ToString();

        }
    }
}
