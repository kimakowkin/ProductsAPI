using ProductsAPI.Models;

namespace ProductsAPI.Services.Interfaces;

public interface IStockService
{
    public ResultModel Remove(ActionProductDto productActionDto);

    public ResultModel Remove(ProductModel product);

    public ResultModel Add(ProductModel product);

    public void Clear();

    public ProductModel? GetProduct(ActionProductDto getProductDto);

    public ListProductDto GetProductList();

    public ResultModel AddProductCount(ChangeProductCountDto productDto);

    public ResultModel RemoveProductCnt(ChangeProductCountDto productDto);

    public void Save();
}

