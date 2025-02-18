/**
 * 07. Hotel Room
 */

namespace _07._Hotel_Room
{

    class Program
    {

        static void Main(string[] arguments)
        {

            //•	На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]

            string mounth = Console.ReadLine();
            int nightsIn = int.Parse(Console.ReadLine());
            

            double apartmentPrice = mounth switch
            {
                "May" or "October" => 65,
                "June" or "September" => 68.7,
                "July" or "August" => 77,
                _ => 0
            };

            //Студио – 50 лв./нощувка	Студио – 75.20 лв./нощувка	Студио – 76 лв./нощувка

            double studioPrice = mounth switch
            {
                "May" or "October" => 50,
                "June" or "September" => 75.2,
                "July" or "August" => 76,
                _ => 0
            };

            //•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            if ((nightsIn > 7 && nightsIn <= 14) && (mounth == "May" || mounth == "October"))
            {
                studioPrice -= studioPrice * 0.05;
            }
            else if (nightsIn > 14 && (mounth == "May" || mounth == "October"))
            {
                studioPrice -= studioPrice * 0.3;
            }
            else if (nightsIn > 14 && (mounth == "June") || mounth == "September")
            {
                studioPrice -= studioPrice * 0.2;
            }
            
            if (nightsIn > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            //•	На първия ред: “Apartment: { цена за целият престой} lv.”
            //•	На втория ред: “Studio: { цена за целият престой} lv.“

            double totalForApartment = apartmentPrice * nightsIn;
            double totalForStudio = studioPrice * nightsIn;

            Console.WriteLine($"Apartment: {totalForApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalForStudio:F2} lv.");

        }

    }

} 