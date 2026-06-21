
namespace G_NET_60_OOP_5
{
    internal class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movieName, decimal price, string seat)
            : base(movieName, price)
        {
            Seat = seat;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {IsBooked}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, Seat);
        }

    }
}
