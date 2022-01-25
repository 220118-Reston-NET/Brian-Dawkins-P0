namespace MemorabiliaModel;
public class Products
{
    public string Name { get; set; }
    public double _price { get; set; }
    public double Price
    {
        get {return Price; }
        set
        {
            if (value > 0)
                {
                    Price = value; 
                }
                else
                {
                    throw new Exception("You cannot have a negative price!");
                }
        }
    }
    public string Category { get; set; }

}
