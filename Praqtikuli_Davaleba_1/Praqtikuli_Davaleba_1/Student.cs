using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praqtikuli_Davaleba_1
{
    //    შექმენით სტუდენტის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს: გვარი,
    //სახელი და ასაკი; ღია მეთოდებს: პირველი მეთოდი პრივატულ ცვლადებს
    //მნიშვნელობებს ანიჭებს; მეორე მეთოდს ეკრანზე გამოაქვს პრივატული
    //ცვლადების მნიშვნელობები.მთავარ პროგრამაში ნაგულისხმევი
    //კონსტრუქტორის გამოყენებით შექმენით შესაბამისი ობიექტი და გამოიძახეთ
    //ორივე მეთოდი.მონაცემების შესატანად გამოიყენეთ TextBox ვიზუალური
    //ელემენტი, გამოსატანად კი Label ვიზუალურ ელემენტი.
    internal class Student
    {
        private string gvari, saxeli;
        private int asaki;
        public void Minicheba(string par_1, string par_2, int par_3)
        {
            gvari = par_1;
            saxeli = par_2;
            asaki = par_3;
        }

        public void Gamotana(Label lab_1)
        {
            lab_1.Text = "გვარი: " + gvari +
                         "\nსახელი: " + saxeli +
                         "\nასაკი: " + asaki.ToString();
        }
    }
}
