// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// string ReadNumb(string messages)
// {
//     Console.Write(messages);
//     return Console.ReadLine();
// }

// int Counter(string mes)
// {
//     Console.WriteLine(mes);
//     string number = "-1";
//     int count = 0;
//     while(number != "stop")
//     {
//         bool b = int.TryParse(number, out int number1);
//         if(b == true)
//         {
//             if(number1 > 0)
//             {
//                 count++;
//             }
//         }
//         number = ReadNumb("=: ");
//     }
//     return count;
// }

// int col = Counter("Введите число или stop");
// System.Console.WriteLine($"Введено {col} положительных чисел");



// int Counter()
//     {
//       Console.Write("Введите число или stop: ");
//       string number = Console.ReadLine();
//       while(number == "stop") return 0;
//       int count = Counter();
//       bool b = int.TryParse(number, out int number2);
//       if(b == true && number2 > 0) count++;
//       return count;
//     }
// int res = Counter();
// Console.WriteLine($"Результат:  {res} чисел");




string ReadNumb(string messages)
{
    Console.Write(messages);
    return Console.ReadLine();
}

int Counter()
    {
      string number = ReadNumb("Введите число или stop: ");
      if(number == "stop") return 0;
      int count = Counter();
      if(int.TryParse(number, out int number2) == true && number2 > 0) count++;
      return count;
    }
int res = Counter();
Console.WriteLine($"Результат:  {res} чисел");



