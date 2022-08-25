class Program{
    class Bil{
        private string modell;
        private string årsmodell;
        private string vikt;
        public void setModell(string m) { modell = m; }
        public string getModell() { return modell; }
        public void setÅr(string å) { årsmodell = å; }
        public string getÅr() { return årsmodell; }
        public void setVikt(string v) { vikt = v; }
        public string getVikt() { return vikt; }

    }
    public static void Main(){
        Bil b = new Bil();
        b.setModell("Modell: Volvo");
        b.setÅr("År: V70");
        Console.WriteLine("Skriv vikt på bilen");
        b.setVikt("Vikt: " + Console.ReadLine() + "Kg");
        Console.Clear();


        string[] Bilar = { b.getModell(), b.getÅr(), b.getVikt()};
        List<string> bil = new List<string>();
        bil.AddRange(Bilar);
        Console.WriteLine("Bil info:");
        Console.WriteLine("");
        foreach (string a in bil)
        {
            Console.WriteLine(a);
        }
    }
}
    