namespace Api.Models;

public class Invoice
{
    public long Id { get; set; }
    public DateOnly Submit { get; set; }
    public double Total { get => Trades.Sum(x => x.Final); }
    public double Payment { get; set; }
    public double Debt { get => Total - Payment; }

    public ICollection<Trade>? Trades { get; set; }
}