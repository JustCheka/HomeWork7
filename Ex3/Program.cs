Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m,n];
Random rand = new Random();

for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = rand.Next(0,20);
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.GetLength(1); i++){
    double sr = 0;
    for (int j= 0; j < arr.GetLength(0); j++){
        sr += arr[j,i];
    }
    sr /= (double) m;
    Console.Write(Math.Round(sr,3) + "; ");
}
Console.WriteLine();