Console.WriteLine("enter number:");
string  numberstr = Console.ReadLine() ??"";
int number = Convert.ToInt32(numberstr);
Console.WriteLine(number);
if (number >9999 && number<100000)
    if (numberstr[0]==numberstr[4] && numberstr[1]==numberstr[3])
    Console.WriteLine("yes it is palindrome");
    else
    Console.WriteLine("no");
else
Console.WriteLine("you enter wrong number");