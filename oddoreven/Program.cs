using System.Transactions;

Console.WriteLine("enter your number");
int usernum = Convert.ToInt32(Console.ReadLine());
int result = usernum % 2;

if (result != 0)
{
    Console.WriteLine("user number is odd");
}
else
{
    Console.WriteLine("Users number is even");
}
