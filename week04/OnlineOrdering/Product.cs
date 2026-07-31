public class Product
{
  private string _productId;
  private string _name;
  private decimal _price;
  private int _quantity;

  public Product(string productId, string name, decimal price, int quantity)
  {
      _productId = productId;
      _name = name;
      _price = price;
      _quantity = quantity;
  }

  public string GetName()
  {
      return _name;
  }
  public string GetProductId()
  {
      return _productId;
  }
  public decimal GetTotalPrice()
  {
      return _price * _quantity;
  }

  public decimal GetPrice()
  {
      return _price;
  }
  public int GetQuantity()
  {
      return _quantity;
  }

}