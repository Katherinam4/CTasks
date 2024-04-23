using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praqtikuli_Davaleba_3
{
    //    შექმენით Klasi_1 კლასი, რომელიც შეიცავს: მთელი ტიპის ერთგანზომილებიან
    //სტატიკურ მასივს, რომლის ინიციალიზებას კონსტრუქტორი ახდენს; პრივატულ
    //ჩვეულებრივ მეთოდს, რომელიც ერთგანზომილებიანი სტატიკური მასივის კენტი
    //ელემენტების ჯამს გასცემს; ღია სტატიკურ მეთოდს, რომელიც ჩვეულებრივ
    //მეთოდს იძახებს და გასცემს შედეგს.მთავარ პროგრამაში შექმენით ობიექტი
    //კონსტრუქტორის გამოყენებით და გამოიძახეთ სტატიკური მეთოდი.

    internal class Klasi_1
    {
        private static int[] static_masivi_1;
        public Klasi_1(int[] par_masivi)
        {
            static_masivi_1 = par_masivi;
        }
        private int Chveulebrivi_Kenti_Raod()
        {
            int raod = 0;
            for (int str = 0; str < static_masivi_1.Length; str++)
                if (static_masivi_1[str] % 2 == 1 ||
                    static_masivi_1[str] % 2 == -1) raod += static_masivi_1[str];

            return raod;
        }
        public static int Static_Method_1(Klasi_1 par_obj)
        {
            return par_obj.Chveulebrivi_Kenti_Raod();

        }
    }
}
