namespace MagiasDiccionarios;

class Program
{
    static void Main(string[] args)
    {
        // DICCIONARIOS
        // No tienen indexadores
        // Instanciamos un diccionario que va a contener el legajo y el nombre de alumnos.
        // La clave(Legajo) será un string, y el valor(el nombre de los alumnos) también.
        Dictionary<string, string> d = new Dictionary<string, string>();
        d.Add("111", "Silvia");
        d.Add("222", "Pepe");
        //d.Add("222", "Coso"); // La clave no se puede repetir dentro del diccionario (rompe en tiempo de ejecución --> directo a recu)
        d.Add("333", "Coso");
        d.Remove("111");        // Borra indicando la clave
        Console.WriteLine("DICCIONARIOS");
        foreach (KeyValuePair<string, string> alumno in d)
        {
            Console.WriteLine($"Legajo: {alumno.Key} - Nombre: {alumno.Value}");
        }
        Console.WriteLine("-----------------------");

        // LISTAS
        // Instanciamos una lista de strings
        List<string> l = new List<string>();
        l.Add("Perro");
        l.Add("Gato");
        l.Add("Pato");
        Console.WriteLine("LISTAS");
        // Las listas sí tienen indexadores
        Console.WriteLine(l[0]);
        Console.WriteLine(l[1]);
        Console.WriteLine(l[2]);
        l.Remove("Perro"); // Borra la ocurrencia coincidente. Si no existe devuelve null.
        foreach (string item in l)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");

        //QUEUE
        // No tienen indexadores
        // Instanciamos una fila de personas que están esperando en un consultorio para ser atendidas
        Queue<string> q = new Queue<string>();
        Console.WriteLine("FILA");
        //Ponemos a personas en la fila.
        q.Enqueue("Rus");
        q.Enqueue("Titi");
        q.Enqueue("Pipi");
        foreach (string item in q)
        {
            Console.WriteLine(item);
        }
        //Sale el primero que llegó que en este caso es Rus
        q.Dequeue();
        foreach (string item in q)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");


        // MONTÓN
        // No tiene indexadores
        // Instanciamos un montón de cartas para ir sacándolas. Es decir, la última del montón es la primera que agarramos.
        Stack<string> s = new Stack<string>();
        Console.WriteLine("MONTÓN");
        s.Push("Dos de oros");
        s.Push("Tres de copas");
        s.Push("Cinco de espadas");
        foreach (string item in s)
        {
            Console.WriteLine(item); //lee del último añadido al primero
        }
        //Sacamos una carta
        s.Pop();
        foreach (string item in s)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");
    }
}