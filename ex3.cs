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

int number = GetNumber("enter number");
for(int i = 1; i<= number; i++)
	
	Console.Write($"{i*i*i},");