
namespace G_NET_60_OOP_5
{
    internal class Cinema
    {

        private IPrintable[] tickets = new IPrintable[100];
        private int count = 0;

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===\n");
        }

        public void Close()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void AddTicket(IPrintable ticket)
        {
            tickets[count++] = ticket;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---\n");

            for (int i = 0; i < count; i++)
            {
                tickets[i].Print();
            }
        }
    }
}
