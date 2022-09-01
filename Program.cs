class Program{
    class Bil{
        public string modell;
        public string årsmodell;
        public string vikt;
        public Bil(string m, string å, string v){
            modell = m;
            årsmodell = å;
            vikt = v;
            modell = "Modell: " + Console.ReadLine();
            årsmodell = "År: " + Console.ReadLine();
            vikt = ("Vikt: " + Console.ReadLine() + "Kg");
        }
    }
    class Fordonslista{
        public Fordonslista(int skrivaUt = 1){
            Bil b = new Bil("", "", "");
            List<Bil> bil = new List<Bil>();
            bil.Add(b);
            foreach (Bil element in bil)
            {
                Console.Clear();
                Console.WriteLine("Bil info:");
                Console.WriteLine("");
                Console.WriteLine(element.modell);
                Console.WriteLine(element.årsmodell);
                Console.WriteLine(element.vikt);
            }
            
            
        }
    }
    public static void Main(){
        Console.Clear();
        int skrivaUt = 1;
        while(skrivaUt != 3){
        Console.WriteLine("Skriv modell, år och vikt på bilen");
        Fordonslista a = new Fordonslista();
        skrivaUt += 1;
        }
    }
}