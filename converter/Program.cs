// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter sum of money you want to convert");
int sum = int.Parse(Console.ReadLine());
Converte converter = new Converte(36.82, 35.86);
Console.WriteLine(converter.ConvertCurrency(sum));
class Converte
{
    private double dollarRate;
    private double euroRate;
    public Converte(double dollarRate, double euroRate)
    {
        this.dollarRate = dollarRate;
        this.euroRate = euroRate;
    }
    public double ConvertCurrency(double SumOfMoney)
    {
        double result;
        Console.WriteLine("Enter: \n1 uah->usd \n2 usd->uah \n3 uah->euro \n4 euro->uah");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Result is ");
        switch (choice)
        {
            case 1:
                return SumOfMoney / dollarRate;
            case 2:
                return SumOfMoney / euroRate;
            case 3:
                return SumOfMoney * dollarRate;
            case 4:
                return SumOfMoney * euroRate;

        }
        return 0;
    }
}