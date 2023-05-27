public class Product {
    private string _productName;
    private string _productId;
    private double _price;
    private double _quantity;
    // price * quantity
    public Product(string productName, string productId, double price, int quantity) {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double GetPrice() {
        return _price;
    }
    public double GetQuantity() {
        return _quantity;
    }
    public string GetName() {
        return _productName;
    }
    public string GetId() {
        return _productId;
    }
}