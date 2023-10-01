// --------------------------------------------------------
// Task 25
int Pow(int d, int p) {
    int res = 1;

    for (int i = 0; i < p; i++) {
        res = res * d;
    }

    return res;
}

Console.Write("Enter the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Pow(n1, n2));

// --------------------------------------------------------
// Task 27
int Summd(int d) {
    int residual;
    int result = 0;

    while (d > 9) {
        residual = d % 10;
        d = d / 10;
        result = result + residual;
    }

    return result + d;
}

Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Summd(n));

// --------------------------------------------------------
// Task 29
Console.Write("Enter the size of the array: ");
int s = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateArray(s));

int[] CreateArray(int size) {
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++) {
        array[i] = new Random().Next(0, 99);
    }

    return array;
}

void PrintArray(int[] massiv) {
    for (int i = 0; i < massiv.Length; i++) {
        Console.Write(massiv[i]);
        Console.Write(" ");
    }
}