// --------------------------------------------------
Console.WriteLine("Task 25 --------------------------");

int Pow(int d, int p) {
    int res = 1;

    for (int i = 0; i < p; i++) {
        res = res * d;
    }

    return res;
}

Console.Write("Enter the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int n2 = -1;
while (n2 < 0) {
    Console.Write("Enter the second number (not negative number): ");
    n2 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Pow(n1, n2));

// --------------------------------------------------
Console.WriteLine("Task 27 --------------------------");

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

int n = -1;
while (n < 0) {
    Console.Write("Enter the number (not negative number): ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Summd(n));

// --------------------------------------------------
Console.WriteLine("Task 29 --------------------------");

PrintArray(CreateArray(8));

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