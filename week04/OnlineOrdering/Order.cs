public class Order
{
  private Customer _customer;
  private List<Product> _products;

  public Order(Customer customer, List<Product> products)
  {
      _customer = customer;
      _products = products;
  }

  public decimal GetTotalOrderCost()
  {
      decimal totalPrice = 0;
      foreach (var product in _products)
      {
          totalPrice += product.GetTotalPrice();
      }
      if (_customer.IsAmericanCustomer())
      {
          totalPrice += 5;
      }
      else
      {
          totalPrice += 35;
      }
      return totalPrice;
  }

  public bool IsAmericanCustomer()
  {
      return _customer.IsAmericanCustomer();
  }

  public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"ID: {product.GetProductId()} - {product.GetName()} - Quantity: {product.GetQuantity()} - Price: ${product.GetPrice()}\n"; 
        }
        if (_customer.IsAmericanCustomer())
        {
            packingLabel += "Shipping Cost: $5\n";
        }
        else
        {
            packingLabel += "Shipping Cost: $35\n";
        }
        return packingLabel;
    }

  public string GetShippingLabel()
  {
      return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
  }
}