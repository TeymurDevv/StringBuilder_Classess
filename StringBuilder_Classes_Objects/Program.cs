using StringBuilder_Classes_Objects.Models;
using System.Text;
Console.WriteLine("Tersini yazmaq ucun yazi daxil edin...");
string givenString = Console.ReadLine();
StringBuilder BuildedString = new StringBuilder();
for (int i = givenString.Length - 1; i >= 0; i--)
{
    BuildedString.Append(givenString[i]);
}
Console.WriteLine("Tersine cevrilmis String:");
Console.WriteLine(BuildedString);
Account loginAttempt = new Account();
loginAttempt.login("lorem123", "123456*");
Factorial fCalculation = new Factorial();
fCalculation.calculate(6);
Calculator Calculation = new Calculator();
Console.WriteLine("1-ci ededi daxil edin...");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("2-ci ededi daxil edin...");
int secondNum = int.Parse(Console.ReadLine());
Calculation.calculate(firstNum,secondNum);