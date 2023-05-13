// Цикл for

// string MethodFour(int count, string text)
// {
//    string result = String.Empty;
//    for (int i = 0; i < count; i++)
//    {
//       result = result + text;
//    }
//    return result;
// }
// string res = MethodFour(12, "text ");
// Console.WriteLine(res);

// Цикл в цикле

// for (int i = 1; i <= 10; i++)
// {
//    for (int j = 2; j <= 10; j++)
//    {
//       Console.WriteLine($"{i} * {j} = {i * j}");
//    }
//    Console.WriteLine();
// }

// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" заменить
// маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели"
+ "бы вас послали вместо нашего милого Винцегероде, вы бы взяли"
+ "приступом согласие прусского короля. Вы так красноречивы. Вы"
+ "дадите мне чаю";

string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty;
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
      if (text[i] == oldValue)
      {
         result = result + $"{newValue}";
      }
      else
      {
         result = result + $"{text[i]}";
      }
   }
   return result;
}

string newText = Replace(text, ' ', '|');
string newText1 = Replace(newText, 'к', 'К');
string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);