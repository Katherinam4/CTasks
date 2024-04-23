using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praqtikuli_Davaleba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            string gvari, saxeli;
            int asaki;
            gvari = textBox1.Text;
            saxeli = textBox2.Text;
            asaki = int.Parse(textBox3.Text);
            student.Minicheba(gvari, saxeli, asaki);
            student.Gamotana(label4);

        }
    }
}
