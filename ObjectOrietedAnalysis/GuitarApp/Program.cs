namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            //
            Guitar requiredGuitar = new Guitar("", 0, "Fender", "Stratocastor", "Electric", "Alder", "Alder");
            var searchResult = inventory.SearchGuitar(requiredGuitar);

            if(searchResult != null )
            {
                Console.WriteLine("Great!!");
                Console.WriteLine("We have this beautiful guitar which matches your specification");
                Console.WriteLine($"This {searchResult.Type} guitar with serial number: {searchResult.SerialNumber} " +
                    $"made of {searchResult.TopWood} at the top and {searchResult.BackWood} at the back is a " +
                    $"great choice!");

            }
            else
            {
                Console.WriteLine($"Sorry! we don't have a guitar which matches your specification");
                Console.WriteLine("You can give it a try with a different specification");
            }

        }

        private static void InitializeInventory(Inventory inventory)
        {
            // Add a few guitars to inventory
            inventory.AddGuitar("11277", 3999.95, "Collings", "CJ", "Acoustic", "Indian Rosewood", "Sitka");
            inventory.AddGuitar("V95693", 1499.95, "Fender", "Stratocastor", "Electric", "Alder", "Alder");
            inventory.AddGuitar("V9512", 1549.95, "Fender", "Stratocastor", "Electric", "Alder", "Alder");
            inventory.AddGuitar("122784", 5495.95, "Martin", "D-18", "Acoustic", "Mahogany", "Adirondack");
            inventory.AddGuitar("76531", 6295.95, "Gibson", "Les Paul", "Electric", "Maple", "Maple");
        }
    }
}
