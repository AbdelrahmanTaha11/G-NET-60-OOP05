


namespace G_NET_60_OOP_5
{
    internal abstract class  Ticket : IPrintable, IBookable, ICloneable
    {
           private static int counter = 0;

    public int TicketId { get; }
    public string MovieName { get; set; }
    public decimal Price { get; set; }
    public bool IsBooked { get; private set; }

    public decimal PriceAfterTax => Price * 1.14m;

    protected Ticket(string movieName, decimal price)
    {
        TicketId = ++counter;
        MovieName = movieName;
        Price = price;
    }

    public bool Book()
    {
        if (IsBooked) return false;
        IsBooked = true;
        return true;
    }

    public bool Cancel()
    {
        if (!IsBooked) return false;
        IsBooked = false;
        return true;
    }

    public abstract void Print();
    public abstract object Clone();

}
}
