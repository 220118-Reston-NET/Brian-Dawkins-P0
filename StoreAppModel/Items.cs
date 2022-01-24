namespace LineItemModel
{
    public class Items
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int Quantity
        {
            get {return Quantity;}
            set
            {
                if (value > 0)
                {
                    Quantity = value; 
                }
                else
                {
                    throw new Exception("You cannot have a quantity lower than 0!");
                }
            }
        }
    }
}