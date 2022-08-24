int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.");
    Console.WriteLine("3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("4. Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            // Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

            int threeDigitNumber = new Random().Next(100,999);
            string stringNumber = Convert.ToString(threeDigitNumber);
            Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);
        break;

        case 2:
            // Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

            int anyNumber = new Random().Next(1,65536);
            string anyNumberText = Convert.ToString(anyNumber);
            if (anyNumberText.Length > 2) {
                Console.WriteLine("третья цифра -> " + anyNumberText[2]);
            }
            else {
                 Console.WriteLine("-> третьей цифры нет");
            }
            break;

        case 3:
            // Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            Console.Write("Введи цифру, обозначающую день недели: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            void CheckingTheDayOfTheWeek (int dayNumber) {
                if (dayNumber == 6 || dayNumber == 7) {
                Console.WriteLine("(этот день выходной) -> да");
                }
                else if (dayNumber < 1 || dayNumber > 7) {
                    Console.WriteLine("это вообще не день недели");
                }
                 else Console.WriteLine("(этот день не выходной) -> нет");
            }
            CheckingTheDayOfTheWeek(dayNumber);
            break;

        case 4:
            // Задача 4: Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23.
            int RandomNumber = new Random().Next(1,1000000);
            if (RandomNumber % 7 == 0 && RandomNumber % 23 == 0) {
                Console.WriteLine("Кратно и 7 и 23");
            } else {
                Console.WriteLine("Не кратно 7 и 23 одновременно");
            }
            break;

        default:
            begin = false;
            break;
    }
}