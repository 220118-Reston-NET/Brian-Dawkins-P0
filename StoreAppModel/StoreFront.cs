using OrderModel;
using ProductModel;

namespace StoreFrontModel
{
    public class StoreFront
    {
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public string ListOfProducts { get; set; }
        // private string _listOfOrders { get; set; }

        // public string ListOfOrders 
        // {
        //     get {return _listOfOrders; }
        // }

        private List<Products> _products;
        public List<Products> Products
        {
            get {return _products; }
            set
            { 
                _products = value;
            }
        }

        private List<Orders> _orders;
        public List<Orders> Orders
        {
            get {return _orders; }
            set
            {
                _orders = value;
            }
        }

        public StoreFront()
        {
            Name = "";
            Address = "";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}";
        }
    }
}