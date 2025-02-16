/**
 * 06. Operations Between Numbers
 */

namespace _06._Operations_Between_Numbers
{

    class Program
    {

        static void Main(string[] arguments)
        {

            //•	N1 – цяло число в интервала[0...1 000 000]
            //•	N2 – цяло число в интервала[0...1 000 000]
            //•	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“

            int leftNumber = int.Parse(Console.ReadLine());
            int rigthNumber = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());

            string status = "";
            string output = "";

            if (rigthNumber == 0 && (Operator == '/' || Operator == '%'))
            {
                output = $"Cannot divide {leftNumber} by zero";
                Console.WriteLine(output);
                Environment.Exit(0);
            }

            double result = Operator switch
            {
                '+' => leftNumber + rigthNumber,
                '-' => leftNumber - rigthNumber,
                '*' => leftNumber * rigthNumber,
                '/' => leftNumber / (rigthNumber * 1.0),
                '%' => leftNumber % rigthNumber,
                _ => 0
            };

            if (result % 2 == 0)
            {
                status = "even";
            }
            else
            {
                status = "odd";
            }

            //Да се отпечата на конзолата един ред:
            //•	Ако операцията е деление:
            //o   "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
            //•	Ако операцията е модулно деление:
            //o   "{N1} % {N2} = {остатък}"
            //•	В случай на деление с 0(нула): 
            //o   "Cannot divide {N1} by zero"

            //10 + 12 = 22 - even

            output = Operator switch
            {
                '+' or '-' or '*' => $"{leftNumber} {Operator} {rigthNumber} = {result} - {status}",   
                '/' => $"{leftNumber} {Operator} {rigthNumber} = {result:F2}",
                '%' => $"{leftNumber} {Operator} {rigthNumber} = {result}",
                _ => ""
            };

            Console.WriteLine(output);

        }

    }

}