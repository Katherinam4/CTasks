using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praqtikuli_Davaleba_2
{
    //    შექმენით საბაზო კლასი, რომელიც შეიცავს დაცულ ცვლადს: მართკუთხედის
    //ფუძეს; ღია კონსტრუქტორს, რომელიც დაცულ ცვლადს მნიშვნელობას ანიჭებს.
    //შექმენით მართკუთხედის მემკვიდრე კლასი, რომელიც დამატებით შეიცავს ღია
    //ცვლადს - მართკუთხედის სიმაღლეს და პრივატულ ცვლადს - მართკუთხედი
    //ფართობს; ღია მეთოდს, რომელიც გამოთვლის და აბრუნებს მართკუთხედის
    //ფართობის მნიშვნელობას.მთავარ პროგრამაში შექმენით მემკვიდრე კლასის
    //ტიპის მქონე ობიექტი და გამოიძახეთ მეთოდი.
    internal class Sabazo
    {
        protected int fudze;

        public Sabazo(int fudze)
        {
            this.fudze = fudze;
        }
    }


    class Martkutxedi : Sabazo
    {
        public int simagle;
        private int fartobi;

        public Martkutxedi(int fudze, int simagle) : base(fudze)
        {
            this.simagle = simagle;
        }

        public int Fart_Mart()
        {
            fartobi = fudze * simagle;
            return fartobi;
        }

    }
}
