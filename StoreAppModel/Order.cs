namespace OrderModel
{
    public class Orders 
    {
        public string LineItems { get; set; }
        public string Location { get; set ;}
        public double Total {get; set; }
        public double Total
        {
            get {return Total; }
            set
            {
                if (value > 0)
                {
                    Total = value; 
                }
                else
                {
                    throw new Exception("You cannot have a negative Total!");
                }
            }
        }
    }
}