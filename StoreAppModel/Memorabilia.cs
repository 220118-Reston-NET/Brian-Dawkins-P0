namespace ProductModel;
public class Products
{
    public int ProductId { get; set; }
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

    public override string ToString()
    {
        return $"=================\nId: {ProductId}\nName: {Name}\nPrice: {_price}\nCatogory: {Category}";
    }

}
