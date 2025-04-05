using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (Product p in products)
        {
            label.AppendLine(p.GetPackingLabel());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetShippingLabel();
    }
}
