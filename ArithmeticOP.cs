//sum 
int a = 10;
int b = 15;
int c = 20;

int sum = a+b+c;
Console.WriteLine("The sum of a, b and c is: " + sum);

//subtraction
int money = 500;
int lost = 150;
int remaining = money - lost;
Console.WriteLine($"Reamaining : {remaining}");

//division
int totalmark = 14+8+12;
int totalquiz = 3;
int avgmark = totalmark / totalquiz;
Console.WriteLine($"Average mark: {avgmark}");

//multiplication
int side = 20;
int area = side*side;
Console.WriteLine($"area is : {area}");

//modulus
int n1 = 12;
int n2 = 3;
int remainder = n1%n2;
Console.WriteLine($"Remain: {remainder}");

//odd even
/*
Console.WriteLine("Enter a number: ");

int number = int.Parse(Console.ReadLine()); //int.parse = convert string to int

if(number % 2 == 0)
{
    Console.WriteLine($"{number} is even....");
}
else
{
    Console.WriteLine("Odd number");
}
*/

//Operator precedence:
//PEDMAS --> Parentheses, Exponents, Multiplication/Division, Addition/Subtraction
//BODMAS --> Bracket, of, Division, Multiplication, Addition and Subtraction


/*
//boolean
int num = 5;

Console.WriteLine("Guess a number between 0 to 10: ");
int guess = int.Parse(Console.ReadLine());

bool right = guess == num;
Console.WriteLine(right);
*/

bool hasCar = true;
bool knowDriving  = true;
bool canDrive = hasCar && knowDriving;
Console.WriteLine($"can drive? {canDrive}");

string name = "";
bool isEmpty = name != "";
Console.WriteLine(isEmpty);