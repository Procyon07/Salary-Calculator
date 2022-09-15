using System;

namespace SalaryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //aastatuluga kuni 14 400(1200) eurot on maksuvaba tulu 6000(500) eurot aastas,
            //aastatulu kasvades 14 400 eurolt 25 200(2100) euroni väheneb maksuvaba tulu vastavalt valemile 6000 – 6000 ÷ 10 800 × (tulu summa – 14 400), (500-500/900*bruto-1200)
            //aastatuluga üle 25 200 euro on maksuvaba tulu 0. (-20%)

            //Palga kalkulaator Test 
            //1. Sina sisestad brutotasu ja valem arvutab välja netotasu.
            //2. Kokku peab olema kolm erinevat meetodit(under 1200, between, over 2100). Enne kui meetod algab, siis peab olema kontroll, et millist meetodi hakatakse kasutama ja sisestatud palgasumma peab minema edasi järgmisse meetodi.
            //3. Netotasu peab arvutama selliselt välja, et sina ei peaks tuludeklaratsiooni ajal juurde maksma ega saa pärast riigilt raha juurde kuna oled rohkem maksnud.
            //4. Kood peab olema inglisekeelne.

            //Tehtud puhtalt tulumaksu pealt, kõik teised maksud on välja arvestatud.

            double gross;
            double net;

            Console.WriteLine("Enter gross salary: ");
            gross = double.Parse(Console.ReadLine());

            if (gross <= 1200)
            {
                Under1200(gross, out net);
                Console.WriteLine($"Your net salary is: {Math.Round(net, 2)}");
            }

            else if (gross > 1200 && gross < 2100)
            {
                BetweenMinMax(gross, out net);
                Console.WriteLine($"Your net salary is: {Math.Round(net, 2)}");
            }

            if (gross >= 2100)
            {
                Over2100(gross, out net);
                Console.WriteLine($"Your net salary is: {Math.Round(net, 2)}");
            }


            static void Under1200(double gross, out double net)
            {
                if (gross > 500)
                {
                    net = gross - (gross - 500) * 0.2;
                }
                else net = gross;
            }

            static void BetweenMinMax(double gross, out double net)
            {
                net = gross - (gross - (500 - 500.0 / 900 * (gross - 1200)))*0.2;
            }

            static void Over2100(double gross, out double net)
            {
                net = gross * 0.8;
            }
        }
    }
}
