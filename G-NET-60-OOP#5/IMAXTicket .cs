
namespace G_NET_60_OOP_5
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {Is3D} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {IsBooked}");
        }

        public override object Clone()
        {
            return new IMAXTicket(MovieName, Price, Is3D);
        }

    }
}
