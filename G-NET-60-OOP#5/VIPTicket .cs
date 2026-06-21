
namespace G_NET_60_OOP_5
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal LoungeFee { get; set; }

        public VIPTicket(string movieName, decimal price, bool loungeAccess, decimal loungeFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            LoungeFee = loungeFee;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {LoungeAccess} | Fee: {LoungeFee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {IsBooked}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess, LoungeFee);
        }

    }
}
