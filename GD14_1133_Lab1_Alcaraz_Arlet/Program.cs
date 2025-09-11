namespace GD14_1133_Lab1_Alcaraz_Arlet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!, my name is Arlet Alcaraz and today is 11 of september 2025");
            Console.WriteLine("Decimal: 0 -> Binary: 0000 -> Hex: 0");
            Console.WriteLine("Decimal: 1 -> Binary: 0001 -> Hex: 1");
            Console.WriteLine("Decimal: 2 -> Binary: 0010 -> Hex: 2");
            Console.WriteLine("Decimal: 4 -> Binary: 0100 -> Hex: 4");
            Console.WriteLine("Decimal: 8 -> Binary: 1000 -> Hex: 8");
            Console.WriteLine("Decimal: 16 -> Binary: 00010000 -> Hex: 10");  //Not really sure if i need to type all the 0 before the 10000 so just to be sure i'm writing them down
            Console.WriteLine("Decimal: 32 -> Binary: 00100000 -> Hex: 20");
            Console.WriteLine("Decimal: 64 -> Binary: 01000000 -> Hex: 40");  //At this point i realized that all the numbers that are the multiplication of decimal 16 will be a multiplication by 10, for example 48 decimal is dec 16(hex10) + dec32(hex20) = dec48(hex30)
            Console.WriteLine("Decimal: 100 -> Binary: 01100100 -> Hex: 64");
            Console.WriteLine("Decimal: 255 -> Binary: 11111111 -> Hex: FF");
            Console.WriteLine("Goodbye! Atte: Arlet Alcaraz date 11 of september 2025");
        }
    }
}
