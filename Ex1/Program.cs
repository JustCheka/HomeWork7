Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());

Random rand = new Random();
double[,] arr = new double[m,n];

for (int i = 0; i < m; i ++){
    for (int j = 0; j < n; j++){
        arr[i,j] = Math.Round(rand.NextDouble() * 20, 3);
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}