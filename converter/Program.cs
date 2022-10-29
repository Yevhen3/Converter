// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Enter sum of money you want to convert");
    decimal sum = decimal.Parse(Console.ReadLine());
    Converter converter = new Converter(37.1m, 36.5m);
    Console.WriteLine(converter.ConvertUAHtoEURO(sum));
}
catch
{
    Console.WriteLine("Your input is incorrect");
}

class Converter
{
    private decimal dollarRate;
    private decimal euroRate;
    public Converter(decimal dollarRate, decimal euroRate)
    {
        this.dollarRate = dollarRate;
        this.euroRate = euroRate;
 
    }
    public decimal ConvertUAHtoUSD(decimal sumOfmoney)
    {
        return sumOfmoney/dollarRate;
    }
    public decimal ConvertUSDtoUAH(decimal sumOfmoney)
    {
        return sumOfmoney * euroRate;
    }
    public decimal ConvertUAHtoEURO(decimal sumOfmoney)
    {
      
        return  sumOfmoney / dollarRate;
    }
    public decimal ConvertEUROtoUAH(decimal sumOfmoney)
    {
        return sumOfmoney * euroRate;
    }
    
}
