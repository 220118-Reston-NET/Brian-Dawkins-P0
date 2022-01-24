namespace StoreFrontModel
{
    public class StoreFrontModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ListOfProducts { get; set; }
        private string _listOfOrders { get; set; }

        public string ListOfOrders 
        {
            get {return _listOfOrders; }
        }
    }
}