int GetNumber(string message)
{
	int result = 0;	
	bool correct = false;
	while(!correct)
		Console.WriteLine(message);
		if(int.TryParse(Console.ReadLine(), out result))
			correct = true;
		else
		   Console.WriteLine("enter correct number");
			
	return (result);
}

int x1 = GetNumber("enter x1");
int y1 = GetNumber("enter y1");
int z1 = GetNumber("enter y1");
int x2 = GetNumber("enter x2");
int y2 = GetNumber("enter y2");
int z2 = GetNumber("enter z2");
double distanse =Math.Sqrt(Math.Pow(x2 -x1,2) + Math.Pow(y2 -y1,2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"distanse between two points:{distanse}");