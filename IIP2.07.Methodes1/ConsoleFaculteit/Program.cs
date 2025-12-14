class Program {
    private static int Faculteit(int n) {
        int result = 1;
        for (int i = 2; i <= n; i++) {
            result *= i;
        }
        return result;
    }
    static void Main(string[] args) {
        Console.Write("Geef een geheel getal: ");
        int getal = int.Parse(Console.ReadLine());
        int faculteit = Faculteit(getal);
        Console.WriteLine($"De faculteit is {faculteit}");
    }
}