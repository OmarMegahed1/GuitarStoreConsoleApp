namespace GuitarStoreConsoleApp
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.FirstOrDefault(guitar => guitar.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            return guitars.Where(guitar => guitar.Spec.Matches(searchSpec)).ToList();
        }
    }
}
