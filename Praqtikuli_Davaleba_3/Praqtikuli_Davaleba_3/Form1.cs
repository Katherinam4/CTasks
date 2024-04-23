using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praqtikuli_Davaleba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] masivi_1 = new int[] { 2, 3, 4, 5, 6 };
            Klasi_1 obj_1 = new Klasi_1(masivi_1);
            int Kenti_raod = Klasi_1.Static_Method_1(obj_1);
            label1.Text = Kenti_raod.ToString();
            label2.Text = " ";
            for (int str = 0; str < masivi_1.Length; str++)
            {
                label2.Text += masivi_1[str].ToString() + " ";
            }

        }
    }
}
