namespace Api.Models;

public class Trade {
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public Unit Unit { get; set; }
    public double Amount { get; set; }
    public double Fee { get; set; }
    public double Discount {get; set;}
    public int TaxRate { get; set; }
    public double Final { get { return ((Fee * Amount) - Discount) - TaxRate; } }
}

public enum Unit {
    Hours,
    Kilograms,
    Meters,
    Watt,

}