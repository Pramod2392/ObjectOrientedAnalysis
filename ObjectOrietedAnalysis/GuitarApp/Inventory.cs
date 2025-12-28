namespace GuitarApp
{
    public class Inventory
    {
        private readonly List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model,
            string type, string backWood, string topWood)
        {
            Guitar newGuitar = new(serialNumber,price,builder,model,type,backWood,topWood);
            _guitars.Add(newGuitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            var guitar = _guitars.FirstOrDefault(x => x.SerialNumber == serialNumber);
            return guitar;
        }

        public Guitar? SearchGuitar(Guitar searchGuitar)
        {
            Guitar? searchResult = null;
            foreach (var guitarFromCollection in _guitars)
            {
                if(!guitarFromCollection.Model.Equals(searchGuitar.Model))
                    continue;                
                if(!guitarFromCollection.Builder.Equals(searchGuitar.Builder))
                    continue;
                if(!guitarFromCollection.TopWood.Equals(searchGuitar.TopWood))
                    continue;
                if(!guitarFromCollection.BackWood.Equals(searchGuitar.BackWood))
                    continue;
                if(!guitarFromCollection.Type.Equals(searchGuitar.Type))
                    continue;
                
                searchResult = guitarFromCollection;
                break;
            }
            return searchResult;
        }
    }
}
