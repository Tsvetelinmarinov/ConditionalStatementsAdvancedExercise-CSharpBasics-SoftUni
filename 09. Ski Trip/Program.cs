/**
 * 09. Ski Trip
 */

//•	Първи ред - дни за престой - цяло число в интервала [0...365]
//•	Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
//•	Трети ред - оценка - "positive"  или "negative"

int daysIn = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string assessment = Console.ReadLine();

double priceForOneNigth = roomType switch
{
    "room for one person" => 18,
    "apartment" => 25,
    "president apartment" => 35,
    _ => 0.0
};

daysIn -= 1;

//вид помещение /        по-малко от 10 дни  /  между 10 и 15 дни   /   повече от 15 дни
//room for one person	не ползва намаление	    не ползва намаление     не ползва намаление
//apartment	            30% от крайната цена	35% от крайната цена	50% от крайната цена
//president apartment	10% от крайната цена	15% от крайната цена	20% от крайната цена

switch (roomType)
{
    case "apartment":
        if (daysIn < 10)
        {
            priceForOneNigth -= priceForOneNigth * 0.3;
        }
        else if (daysIn >= 10 && daysIn <= 15)
        {
            priceForOneNigth -= priceForOneNigth * 0.35;
        }
        else
        {
            priceForOneNigth -= priceForOneNigth * 0.5;
        }
        break;
    case "president apartment":
        if (daysIn < 10)
        {
            priceForOneNigth -= priceForOneNigth * 0.1;
        }
        else if (daysIn >= 10 && daysIn <= 15)
        {
            priceForOneNigth -= priceForOneNigth * 0.15;
        }
        else
        {
            priceForOneNigth -= priceForOneNigth * 0.2;
        }
    break;
}

double total = daysIn * priceForOneNigth;

//Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея.
//Ако оценката му е негативна приспада от цената 10%.

total = assessment switch
{
    "positive" => total += total * 0.25,
    "negative" => total -= total * 0.1,
    _ => total += 0
};

Console.WriteLine("{0:F2}", total);