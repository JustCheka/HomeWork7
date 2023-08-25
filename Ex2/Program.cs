Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Какой элемент хотите вывести");
int num = int.Parse(Console.ReadLine());

Random rand = new Random();
int[,] arr = new int[m,n];

int sum = 0;
int i1 = 0;
int j1 = 0;
for (int i = 0; i < m; i++){
    for (int j= 0; j < n; j++){
        arr[i,j] = rand.Next(0,1000);
        Console.Write(arr[i,j] + " ");
        sum++;
        if (sum == num) {
            i1 = i;
            j1 = j;
        }
    }
    Console.WriteLine();
}
if (num > arr.Length){
    Console.WriteLine("Такого числа нет");
}
else Console.WriteLine(arr[i1,j1]);