using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcıdan doğum tarihi alınacak ve yaşı hesaplanıp mesaj verilecek
            int fark,girilenyil;
            string mesaj;
            int suankiyil = Convert.ToInt32(DateTime.Now.ToString("%y"));
            Console.WriteLine();
            suankiyil += 2000;
            Console.WriteLine("{0} yılındayız",suankiyil);
            Console.WriteLine("Doğum yılınızı yazınız:");
            girilenyil = Convert.ToInt32(Console.ReadLine());
            fark = suankiyil - girilenyil;
            if (fark < 20)
            {
                mesaj = "Ergensin:D";
            }
            else if (fark < 30)
            {
                mesaj = "Gençsiniz:D";
            }
            else if (fark < 40)
            {
                mesaj = "Yaşlanıyorsunuz:(";
            }
            else
            {
                mesaj = "Yaşlısınız";

            }
            Console.WriteLine(mesaj);

            Console.ReadLine();
        }
    }
}
