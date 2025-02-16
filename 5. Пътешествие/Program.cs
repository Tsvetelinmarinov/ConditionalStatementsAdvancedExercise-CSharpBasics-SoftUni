

using static System.Runtime.InteropServices.JavaScript.JSType;

/**
 * 5.	Пътешествие
 */

namespace _5._Пътешествие
{

    class Program
    {

        static void Main(string[] args)
        {

            //•	Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double tripPrice = 0;

            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи.
            //Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от
            //сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена
            //цена която отговаря на даден процент от бюджета:

            string buildingType = season switch
            {
                "summer" => "Camp",
                "winter" => "Hotel",
                _ => ""
            };

            if (budget > 1000)
            {
                buildingType = "Hotel";
            }

            if (budget > 0 && budget <= 100)
            {
                destination = "Bulgaria";
                tripPrice = season switch
                {
                    "summer" => budget * 0.3,
                    "winter" => budget * 0.7,
                    _ => 0
                };
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                tripPrice = season switch
                {
                    "summer" => budget * 0.4,
                    "winter" => budget * 0.8,
                    _ => 0
                };
            }
            else
            {
                destination = "Europe";
                tripPrice = budget * 0.9;
            }

            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{Вид почивка} - {Похарчена сума}“
            //o	Почивката може да е между „Camp” и „Hotel”
            //o	Сумата трябва да е закръглена с точност до вторият знак след запетаята

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{buildingType} - {tripPrice:F2}");

        }

    }

}