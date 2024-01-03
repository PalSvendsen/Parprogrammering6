namespace Parprogrammering6
{
    public class ElectronicItem : InventoryItem, ISellable
    {
        public string Warranty {  get; set; }
        public int Voltage { get; set; }

        public ElectronicItem(string name, int quantity, double price, string warranty, int voltage) : base(name, quantity, price)
        {
            Warranty = warranty;
            Voltage = voltage;
        }

        public double CalculatePrice()
        {
            return Price * Quantity;
        }

    }
}
