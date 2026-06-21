

namespace G_NET_60_OOP_5
{
    internal static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\nBookingHelper.PrintAll\n");

            foreach (var item in items)
            {
                item.Print();
            }
        }

    }
}
