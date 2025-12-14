class Program {
    private static bool IsSchrikkeljaar(int jaar) {
        if (jaar % 400 == 0) {
            return true;
        }
        if (jaar % 100 == 0) {
            return false;
        }
        if (jaar % 4 == 0) {
            return true;
        }
        return false;
    }
    static void Main(string[] args) {
        Console.WriteLine("SCHRIKKELJAAR");
        Console.WriteLine("============");
        int jaar;
        do {
            Console.Write("Geef een jaar tal: ");
            jaar = int.Parse(Console.ReadLine());         
            if (jaar > 0) {
                if (IsSchrikkeljaar(jaar)) {
                    Console.WriteLine($"Het jaar {jaar} is een schrikkeljaar");
                } else {
                    Console.WriteLine($"Het jaar {jaar} is geen schrikkeljaar");
                }
            }
        } while (jaar > 0);
        Console.WriteLine("Bedankt en tot ziens.");
    }
}