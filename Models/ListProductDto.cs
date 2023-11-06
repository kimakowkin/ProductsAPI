namespace ProductsAPI.Models;
public class ListProductDto
{
    public List<ProductModel> products {  get; set; }
    public int Count { get; set; }
    public decimal CommonCost { get; set; }
}
