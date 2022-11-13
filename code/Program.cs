string[] arr1 = { "hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

string func(string[] mas) {
    int k = 1;
    string[] masRes = new string[1];
    for (int i = 0; i < mas.Length; i++) {
        if (mas[i].Length <= 3) {
            masRes[k-1] = mas[i]; 
            k++;
            Array.Resize<string>(ref masRes, k);            
        }
    }
    for (int i = 0; i < mas.Length; i++) {
        Console.Write($"'{mas[i]}' ");
    }
    Console.Write(" -> ");
    for (int i = 0; i < masRes.Length - 1; i++) {
        Console.Write($"'{masRes[i]}' ");
    }
    Console.WriteLine();
    return "1";
}
func(arr1);
func(arr2);
func(arr3);