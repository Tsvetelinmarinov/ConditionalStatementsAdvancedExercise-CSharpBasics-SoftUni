/**
 * 4.	Лодка за риболов
 */
namespace _4._Лодка_за_риболов
{

    class Program
    {

        static void Main(string[] args)
        {

            //•	Бюджет на групата – цяло число в интервала[1…8000]
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //•	Брой рибари – цяло число в интервала[4…18]

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            //•	Цената за наем на кораба през пролетта е  3000 лв.
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.

            double boatPrice = season switch
            {
                "Spring" => 3000,
                "Summer" or "Autumn" => 4200,
                "Winter" => 2600,
                _ => 0
            };

            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.

            if (fishermans > 0 && fishermans <= 6)
            {
                boatPrice -= boatPrice * 0.1;
            }
            else if (fishermans > 7 && fishermans <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;
            }

            //Рибарите ползват допълнително 5% отстъпка,
            //ако са четен брой освен ако не е есен - тогава нямат 

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                boatPrice -= boatPrice * 0.05;
            }

           // •	Ако бюджетът е достатъчен:
           //     "Yes! You have {останалите пари} leva left."
           //•	Ако бюджетът НЕ Е достатъчен:
           //     "Not enough money! You need {сумата, която не достига} leva."

            if (boatPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - boatPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - budget:F2} leva.");
            }
        }

    }
    
}