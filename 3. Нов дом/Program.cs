/**
 * 3.	Нов дом
 */

//•	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
//•	Брой цветя - цяло число в интервала [10…1000]
//•	Бюджет - цяло число в интервала [50…2500]

string flowerType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//цвете                 Роза	Далия	Лале	Нарцис	Гладиола
//Цена на брой в лева	   5	  3.80	2.80	   3	  2.50

double flowerPrice = flowerType switch
{
    "Roses" => 5,
    "Dahlias" => 3.8,
    "Tulips" => 2.8,
    "Narcissus" => 3,
    "Gladiolus" => 2.5,
    _ => 0
};

double total = flowersCount * flowerPrice;

//•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
//•	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
//•	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
//•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
//•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%

if (flowerType == "Roses" && flowersCount > 80)
{
    total -= total * 0.1;
}
else if (flowerType == "Dahlias" && flowersCount > 90)
{
    total -= total * 0.15;
}
else if (flowerType == "Tulips" && flowersCount > 80)
{
    total -= total * 0.15;
}
else if (flowerType == "Narcissus" && flowersCount < 120)
{
    total += total * 0.15;
}
else if (flowerType == "Gladiolus" && flowersCount < 80)
{
    total += total * 0.2;
}

//•	Ако бюджета им е достатъчен
//   - "Hey, you have a great garden with {броя цветя} {вид цветя} and {останалата сума} leva left."
//•	Ако бюджета им е НЕ достатъчен
//   - "Not enough money, you need {нужната сума} leva more."

if (total <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {budget - total:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
}