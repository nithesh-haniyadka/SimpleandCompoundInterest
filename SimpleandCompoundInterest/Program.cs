namespace simpleIntrest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest simpleInterest = new SimpleInterest();
            CompoundInterest compoundInterest = new CompoundInterest();
            int input1, input2;
            Console.WriteLine("Enter the principle");
            input1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the time");
            input2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            int input3 = Convert.ToInt16(Console.ReadLine());
            double final = simpleInterest.intrest(input1, input2, input3);
            double final2 = compoundInterest.intrest(input1, input2, input3);
            Console.WriteLine("Simple intrest=" + final + "\n Compound intrest " + final2); 
            Console.ReadKey();
        }

    }
}