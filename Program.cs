using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stajçalışma2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adınızı giriniz.");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz.");
            string soyad = Console.ReadLine();

            Console.WriteLine("Sırasıyla doğum gününüzü, ayınızı ve yılınızı giriniz.");
            int gun = Convert.ToInt32(Console.ReadLine());
            int ay = Convert.ToInt32(Console.ReadLine());
            int yil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sırasıyla sigortalı olduğunuz gününüzü, ayınızı ve yılınızı giriniz.");
            int sigortagun = Convert.ToInt32(Console.ReadLine());
            int sigortaay = Convert.ToInt32(Console.ReadLine());
            int sigortayil = Convert.ToInt32(Console.ReadLine());

            DateTime dogumTarihi = new DateTime(yil, ay, gun);
            DateTime sigortaGunu = new DateTime(sigortayil, sigortaay, sigortagun);
            DateTime simdi = DateTime.Now;

            TimeSpan yas = simdi - dogumTarihi;
            TimeSpan sigorta = simdi - sigortaGunu;

            var toplamGun = (simdi - dogumTarihi).TotalDays;
            double yasYil = yas.Days / 365;
            double yasAy = Math.Round((toplamGun - (365 * yasYil)) / 30, 0);
            double yasGun = Math.Abs(Math.Round((toplamGun - (365 * yasYil)) - (yasAy * 30), 0));

            var toplamSigortaGun = (simdi - sigortaGunu).TotalDays;
            double sigortaYil = sigorta.Days / 365;
            double sigortaAy = Math.Round((toplamSigortaGun - (365 * sigortaYil)) / 30, 0);
            double sigortaGun = Math.Abs(Math.Round((toplamSigortaGun - (365 * sigortaYil)) - (sigortaAy * 30), 0));

            Console.WriteLine("Adınız :" + ad);
            Console.WriteLine("Soyadınız :" + soyad);
            Console.WriteLine("Yaşınız :" + yasYil + " yıl, " + yasAy + " ay, " + yasGun + " gün ");
            Console.WriteLine("Sigortalılık Süreniz :" + sigortaYil + " yıl, " + sigortaAy + " ay, " + sigortaGun + " gün ");
            Console.WriteLine("Bu işlemi " + simdi + " tarihinde gerçekleştirdiniz.");
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
