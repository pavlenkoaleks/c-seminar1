Random random = new Random();
int number = random.Next(1,1000);
Console.WriteLine(number);

int number1 = number / 100;
int number3 = number % 10;
int result = number1*10+number3;

Console.WriteLine(result);