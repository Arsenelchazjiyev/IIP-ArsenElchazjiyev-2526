class Program {
    private static void MaakTafel(int get, int len = 10) {
        for (int i = 1; i <= len; i++) {
            Console.WriteLine($"{get} x {i} = {get * i}");
        }
    }

    private static int VraagPositiefGetal() {
        int getal;
        do {
            Console.Write("Geef een positief getal: ");
            getal = int.Parse(Console.ReadLine());
        } while (getal <= 0);
        return getal;
    }
    static void Main(string[] args) {
        MaakTafel(4, 6);
        Console.WriteLine();
        MaakTafel(2, 5);
        Console.WriteLine();
        MaakTafel(7);
        Console.WriteLine();
        int getal = VraagPositiefGetal();
        int lengte = VraagPositiefGetal();
        MaakTafel(getal, lengte);
    }
}