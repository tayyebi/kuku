namespace Api.Models;

public class Invoice
{
    public long Id { get; set; }
    public DateOnly Submit { get; set; }
    public List<Trade> Trades { get; set; }
    public double Total { get => Trades.Sum(x => x.Final); }
    public double Payment { get; set; }
    public double Debt { get => Total - Payment; }
}