using System;

namespace ConsoleApp2
{
    class Matrix
    {
        public float Ampl { get; set; }
        public float Phase { get; set; }
        public static Matrix Sum (Matrix x, Matrix y)
        {
            Matrix M = new Matrix
            {
                Ampl = x.Ampl + y.Ampl,
                Phase = x.Phase + y.Phase
            };
            return M;
        }
        public static Matrix operator + (Matrix x, Matrix y)
        {
            return Matrix.Sum(x, y);
        }
       
    }
    class Program
    {
        static void Main()
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");   //decimal separator "."
            Console.Write("Enter the amplitude of the first vector Ample: ");
            m1.Ampl = (float.Parse)(Console.ReadLine());
            Console.Write("Enter the phase of the first vector Phase: ");
            m1.Phase = (float.Parse)(Console.ReadLine());
            Console.Write("Enter the amplitude of the second vector Ample: ");
            m2.Ampl = (float.Parse)(Console.ReadLine());
            Console.Write("Enter the phase of the second vector Phase: ");
            m2.Phase = (float.Parse)(Console.ReadLine());
            Console.WriteLine($"Sum: { m1.Ampl + m2.Ampl}, {m1.Phase + m2.Phase}");
            Console.ReadKey();
        }
    }
}