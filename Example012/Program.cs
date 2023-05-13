// Вид1
void MethodOne()
{
   Console.WriteLine("Автор...");
}
// MethodOne();

// Вид2
void MethodTwo(string msg)
{
   Console.WriteLine(msg);
}
// MethodTwo("Текст сообщения...");

void MethodTwoOne(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
      Console.WriteLine(msg);
      i++;
   }
}
// MethodTwoOne("Текст сообщения...", 4);
// MethodTwoOne(count: 4, msg: "Текст сообщения...");

// Вид3

int MethodThree()
{
   return DateTime.Now.Year;
}
// int year = MethodThree();
// Console.WriteLine(year);

// Вид4

string MethodFour(int count, string text)
{
   int i = 0;
   string result = String.Empty;
   while (i < count)
   {
      result = result + text;
      i++;
   }
   return result;
}
string res = MethodFour(12, "text ");
Console.WriteLine(res);