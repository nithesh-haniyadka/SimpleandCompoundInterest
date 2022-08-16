namespace simpleCompoundInterest
{   public class simpleCompoundInterest
    {        
        public class Math : Imath
        {
            int x, y, z;
            double d;
            public double add(double a, double b)
            {

                double h = a + b;
                return h;
            }

            public void subtract(int a, int b)
            {

                y = a - b;
            }

            public double mulitply(int a, int b, int c)
            {
                double mul = a * b * c;
                return mul;

            }

            public double division(double a, double b)
            {

                d = a / b;
                return d;
            }

            public void display()
            {
                Console.WriteLine("Sum : " + x);
                Console.WriteLine("Substract : " + y);
                Console.WriteLine("Multiply :" + z);
                Console.WriteLine("Division :" + d);


            }

            public double mulitply(double a, double b)
            {
                double d;
                d = a * b;
                return d;
            }
        }
        public interface Imath
        {
            double add(double a, double b);
            void subtract(int a, int b);
            double mulitply(int a, int b, int c);
            double mulitply(double a, double b);
            double division(double a, double b);
            void display();
        }

        [Fact]
        public void Add()
        {
            var calculator = new Math();
            Assert.Equal(4, calculator.add(2, 2));


        }
       

        [Fact]
        public void mulitply()
        {
            var calculator = new Math();
            Assert.Equal(6, calculator.mulitply(3, 2));
            Assert.Equal(18, calculator.mulitply(3, 3, 2));


        }

       

        [Fact]
        public void division()
        {
            var calculator = new Math();
            Assert.Equal(1, calculator.division(2, 2));


        }

        public double intrest(int princip, int Time, int rate)
        {

            Imath imath = new Math(); //Calling an interface
            double multi = imath.mulitply(princip, Time, rate);
            double denominator = 100;
            double intrest = imath.division(Convert.ToInt32(multi), denominator);
            return intrest;


        }


        [Fact]
        public void SimpleInterest()

        {
            Imath imath = new Math();
            double multi = imath.mulitply(1200, 5, 12);
            double denominator = 100;
            double intrest = imath.division(Convert.ToInt32(multi), denominator);
            Assert.Equal(720, 720);


        }

        public double intrestNew(int princip, int Time, int rate)
        {

            Imath imath = new Math();
            double denominator = 100;
            double divide = imath.division(rate, denominator);
            double add = 1;
            double addsum = imath.add(add, divide);
            double ci = 1;
            for (int i = 1; i <= Time; i++)
            {
                ci = imath.mulitply(ci, addsum);

            }
            double intrest = imath.mulitply(ci, princip);

            return intrest;

        }

        [Fact]
        public void CompoudnInterest()

        {
            Imath imath = new Math();
            double denominator = 100;
            double divide = imath.division(2, denominator);
            double add = 1;
            double addsum = imath.add(add, divide);
            double ci = 1;
            for (int i = 1; i <= 2; i++)
            {
                ci = imath.mulitply(ci, addsum);

            }
            double intrest = imath.mulitply(ci, 2);

            Assert.Equal(2.0808, 2.0808);


        }






    }
}