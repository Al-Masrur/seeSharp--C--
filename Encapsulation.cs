/*
public class Student
{
    //all attributes are private to maintain security
    private string name;
    private int roll;
    private double totalMark;
    private double grade;

    public Student(string n, int r, double t, double g)
    {
        name = n;
        roll = r;
        totalMark =t;
        grade = g;
    }

    public string GetName()
    {
        return name;
    }

    public int GetRoll()
    {
        return roll;
    }
    public double GetGrade()
    {
        return grade;
    }
    public void setGrade(double g)
    {
        grade = g;
    }
}

class Encapsulation
{
    static void Main(String[] args)
    {
        Student masrur = new Student("Masrur",147,84.5,4.00);
        //Console.WriteLine(masrur.name); //cant access name directly, name is private
        Console.WriteLine(masrur.GetName());
        Console.WriteLine(masrur.GetRoll());
        Console.WriteLine(masrur.GetGrade());
        masrur.setGrade(3.94);
        Console.WriteLine($"After update, Grade: {masrur.GetGrade()}");

    }
}


*/


public class Bank
{
    private string accountHolder;
    private double balance;

    public Bank(string accountHolder, double balance)
    {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public string Name
    {
        get{return accountHolder;}
    }
    public double Balance
    {
        get{return balance;}
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance+=amount;
            Console.WriteLine($"{amount} taka deposited successfully.....\nNew Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Error: not valid amount!!!!!");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine($"Youre trying to withdraw more money than you have....You currently have {balance}");
        }
        else if (amount<=0)
        {
            Console.WriteLine("Error: invalid amount. Must be greater than 0");
        }
        else
        {
            balance-=amount;
            Console.WriteLine($"successfully withdrawn {amount} taka........\nCurrent balance: {balance}");
        }
    }
}

class Encapsulation
{
    static void Main(String[] args)
    {
        Bank acc = new Bank("Masrur",3000);
        Console.WriteLine($"Name: {acc.Name}");
        Console.WriteLine("Balance: "+acc.Balance);
        acc.Deposit(5000.50);
        acc.Withdraw(9000);
        acc.Withdraw(8000);
    }
}