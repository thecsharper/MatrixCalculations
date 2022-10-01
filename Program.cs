using MatrixCalculations;

namespace matrix_library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // examples
            var A = new Matrix("4 3 2 2; 0 1 0 -2; 1 -1 3 3; 2 3 1 1");

            Console.WriteLine("A =");
            Console.WriteLine(A);

            Console.WriteLine($"determinant = {Matrix.Det(A)}\n");

            Console.WriteLine($"REF:");
            Console.WriteLine(Matrix.REF(A));

            Console.WriteLine("RREF:");
            Console.WriteLine(Matrix.RREF(A));

            Console.WriteLine("A^(-1)");
            Console.WriteLine(Matrix.Inverse(A));

            Console.WriteLine("Eigenvalues:");
            Console.WriteLine(Matrix.EigenValues(A));

            Console.WriteLine("3 * A =");
            Console.WriteLine(3 * A);

            Console.WriteLine("A * A =");
            Console.WriteLine(A * A);

            Console.WriteLine("QR decomposition:\nA =\n");
            var QR = Matrix.QR_Decomp(A);
            Console.WriteLine(QR[0]);
            Console.WriteLine("*\n");
            Console.WriteLine(QR[1]);

            var B = new Matrix("2 5 1 4; 4 1 6 3; 5 3 7 2; 1 0 2 4");

            Console.WriteLine("B =");
            Console.WriteLine(B);

            Console.WriteLine("Matrix multiplication:\nA * B =");
            Console.WriteLine(A * B);
        }
    }
}