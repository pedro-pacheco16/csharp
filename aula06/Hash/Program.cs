namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "allan",
                "robson",
                "joão",
                "ingrid",
                "allan",
                "robson",
            };

            foreach(var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("pedro");
            setNomes.Add(null);
            setNomes.Add("julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("O nome julia existe?" + setNomes.Contains("julia"));

            setNomes.Remove("joão");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in setNomes)
            {
                Console.WriteLine(hash);
            }
        }  
    }
}