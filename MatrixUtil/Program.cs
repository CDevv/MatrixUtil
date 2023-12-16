using MathNet.Numerics.LinearAlgebra.Double;

Console.WriteLine("First matrix:");
double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
DenseMatrix matrix1 = DenseMatrix.OfArray(new double[,]
{
                { numbers[0], numbers[1], numbers[2] },
                { numbers[3], numbers[4], numbers[5] },
                { numbers[6], numbers[7], numbers[8] }
});

Console.WriteLine("Second matrix:");
numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
DenseMatrix matrix2 = DenseMatrix.OfArray(new double[,]
{
                { numbers[0], numbers[1], numbers[2] },
                { numbers[3], numbers[4], numbers[5] },
                { numbers[6], numbers[7], numbers[8] }
});

Console.WriteLine("Action:");
int actionCode = int.Parse(Console.ReadLine());
switch (actionCode)
{
    default:
        break;
    case 1:
        //Multiply
        Console.WriteLine("Multiply by:");
        double multiplier = double.Parse(Console.ReadLine());
        DenseMatrix matrixMultiplied1 = matrix1 * multiplier;
        DenseMatrix matrixMultiplied2 = matrix2 * multiplier;

        Console.WriteLine("New Matrix1:");
        Console.WriteLine(matrixMultiplied1);
        Console.WriteLine("New Matrix2:");
        Console.WriteLine(matrixMultiplied2);
        break;
    case 2:
        //Sum two matrixes
        DenseMatrix result = matrix1 + matrix2;
        Console.WriteLine(result);
        break;
    case 3:
        //Determenant
        double determenant1 = matrix1.Determinant();
        double determenant2 = matrix2.Determinant();
        Console.WriteLine($"Matrix 1 Determenant: {determenant1}");
        Console.WriteLine($"Matrix 2 Determenant: {determenant2}");
        break;
    case 4:
        //Solve
        Console.WriteLine("Vector 1:");
        double[] vector1Numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        DenseVector vector1 = new(vector1Numbers);
        DenseVector result1 = (DenseVector)matrix1.Solve(vector1);

        Console.WriteLine("Vector 2:");
        double[] vector2Numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        DenseVector vector2 = new(vector2Numbers);
        DenseVector result2 = (DenseVector)matrix2.Solve(vector2);

        Console.WriteLine($"Matrix 1 result: {result1}");
        Console.WriteLine($"Matrix 2 result: {result2}");
        break;
}
