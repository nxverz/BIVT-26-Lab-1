namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer1 = false;

            // code here
            answer1 = Math.Abs(d) >= 1;
            // end

            return answer1;
        }
        public bool Task2(double d, double f)
        {
            bool answer2 = false;

            // code here
            answer2 = (d + f) / 2 > 0;
            // end

            return answer2;
        }
        public bool Task3(int a, int b)
        {
            bool answer3 = false;
            // code here
            answer3 = (a + b) > (Math.Abs(a) + Math.Abs(b)) / 2;
            // end

            return answer3;
        }
        public int Task4(int a, int b, int c)
        {
            int answer4 = 0;

            // code here
            if (b > answer4) answer4 = b;
            if (c > answer4) answer4 = c;

            // end

            return answer4;
        }
        public double Task5(double x)
        {
            double answer5 = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer5 = 0;
            }
            else
            {
                answer5 = x * x - 1;
            }

            // end

            return answer5;
        }
        public bool Task6(double x, double y)
        {
            bool answer6 = false;

            // code here
            if (y >= 0 && y <= 1 - Math.Abs(x))
            
                answer6 = true;
            

            // end

            return answer6;
        }

        public bool Task7(int n)
        {
            bool answer7 = true;

            // code here
            if (n < 0)
            {
                answer7 = false;
            }
            else if (n % 2 == 0)
            {
                answer7 = false;
            }

            // end

            return answer7;
        }
        public bool Task8(int X, int Y)
        {
            bool answer8 = false;

            // code here
            int chay = X / 2; 
            int shift = (X * Y) + (Y * chay); 
            if (shift >= 420)

                answer8 = true; 

            // end

            return answer8;
        }
    }
}
}
