string[] frutas = new string[3];
            frutas[0] = "Manzana";
            frutas[1] = "Banana";
            frutas[2] = "Cereza";

            Console.WriteLine("Lista de frutas:");

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}


 List<string> frutasList = new List<string>();
            frutasList.Add("Mango");
            frutasList.Add("Pera");
            frutasList.Add("Uva");

            foreach (string fruta in frutasList)
            {
                Console.WriteLine("Lista: " + fruta);
            }

            Console.WriteLine();

            Dictionary<string, int> frutasDicc = new Dictionary<string, int>();
            frutasDicc.Add("Kiwi", 10);
            frutasDicc.Add("Melon", 10);
            frutasDicc.Add("Cereza", 30);

            foreach (var fruta in frutasDicc)
            {
                Console.WriteLine("Diccionario: " + fruta.Key + " - " + fruta.Value);
            }