namespace CrudDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CRUDdictionary<string, string> myDictionary = new CRUDdictionary<string, string>();
            myDictionary.Add("a", "b");
            myDictionary.Add("c", "d");
            Console.WriteLine(myDictionary.Get("a"));
        }
    }
}
