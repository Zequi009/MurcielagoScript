

class Program
{
    static void Main()
    {
        // Diccionario de codificación usando la palabra "MURCIELAGO"
        Dictionary<char, char> codificacion = new Dictionary<char, char>()
        {
            { 'M', '0' },
            { 'U', '1' },
            { 'R', '2' },
            { 'C', '3' },
            { 'I', '4' },
            { 'E', '5' },
            { 'L', '6' },
            { 'A', '7' },
            { 'G', '8' },
            { 'O', '9' }
        };


        Console.Write(@"seleccione 'C' para codificar ó 'D' para decodificar ");
        string seleccion = Console.ReadLine().ToUpper();

        // Console.Write("Escribe una palabra para codificar: ");
        // string palabraUsuario = Console.ReadLine().ToUpper();
        // string palabraCodificada = "";

        // // Reemplazar cada letra de la palabra con su correspondiente en la codificación, si aplica
        // foreach (char letra in palabraUsuario)
        // {
        //     if (codificacion.ContainsKey(letra))
        //     {
        //         palabraCodificada += codificacion[letra];
        //     }
        //     else
        //     {
        //         palabraCodificada += letra; // Si la letra no está en MURCIELAGO, la dejamos igual
        //     }
        // }
        // Console.WriteLine(@"#########################################");
        // Console.WriteLine($"\npalabra a codificar\t{palabraUsuario}\n");
        // Console.WriteLine($"palabra a codificada\t{palabraCodificada}\n");
        // Console.WriteLine(@"#########################################");

    }
}
