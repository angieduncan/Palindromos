using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Palindromo
    { public string Pharse { get; set };
        public Boolean EstadoPalindromo { get; set };

        public Palindromo()
        {
            Pharse = "";
            EstadoPalindromo = true;
        }

       
        public void ValidarPalindromo()
        {
            Array p = Pharse.ToCharArray();
            for(int i=0; i<p.Length - 1;i++)
            {
                if (p[i].Equals( p.Length - 1 - i))
                {
                    EstadoPalindromo = true;
                }
                else
                {
                    EstadoPalindromo = false;
                    c = c + 1;

                }
            }
        }


    }
}
