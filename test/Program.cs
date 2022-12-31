// string newstr = ""; 
// for (int i = 0; ;i++) 
// { 
// Console.WriteLine($"Введите число {i + 1}, для прекращения ввода введите stop"); 
// string str = Console.ReadLine(); 
// newstr = newstr + str; 
// if (str == "stop") 
// { 
//    break; 
// } 
 
// } 
// Console.WriteLine(newstr); 
//  int[] myArray = new int[newstr.Length-4]; 
//  Console.WriteLine($"{string.Join(", ", myArray)}");
// for (int j = 0; j < newstr.Length-4; j++) 
// { 
//  myArray[j] = newstr[j] -'0'; 
//  } 
// Console.WriteLine($"{string.Join(", ", myArray)}");   
// int count = 0; 
// for (int d = 0;d < myArray.Length; d++) 
// { 
//    if (myArray[d] < 0) 
//    { 
//       count = count +1; 
//    } 
// } 
// Console.WriteLine($"Количество отрицательных элементов введено: {count}");


string numb = "";
while (numb.ToLower() != "stop")
{
    Console.WriteLine("Введите число, закончите ввод словом stop");
    Convert.ToInt32(Console.ReadLine(numb));
}
