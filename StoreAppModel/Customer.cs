namespace CustomerModel
{
    public class Customer 
    { 
        public string Name { get; set;}
        private string _address { get; set; }
         public string Address 
        {
            get {return _address; }

        }
        private string _phoneNumber { get; set; }
        public string PhoneNumber
        {
            get { return _phoneNumber;}

        }
        public string listOfOrders { get; set; }

       
        
    }
}