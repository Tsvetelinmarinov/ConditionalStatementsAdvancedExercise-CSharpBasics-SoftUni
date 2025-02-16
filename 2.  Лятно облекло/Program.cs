/**
 * 2. Лятно облекло
 */

//•	Градусите - цяло число в интервала [10…42]
//•	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"

int degrees = int.Parse(Console.ReadLine());
string partOfTheDay = Console.ReadLine();

string outfit = "";
string shoes = "";

switch (partOfTheDay)
{
    case "Morning":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
        else if (degrees > 18 && degrees <= 24)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        break;
    case "Afternoon":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees > 18 && degrees <= 24)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else
        {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
        break;
    case "Evening":
        outfit = "Shirt";
        shoes = "Moccasins";
        break;
    default:
        outfit = "unknown";
        shoes = "unknown";
    break;
}

//Да се отпечата на конзолата на един ред:
//  "It's {градуси} degrees, get your {облекло} and {обувки}."

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");