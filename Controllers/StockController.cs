using ProductsAPI.Models;
using ProductsAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;
using ProductsAPI.Services.Interfaces;

namespace ProductsAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly IStockService _stockService;

    public StockController(IStockService stockService)
    {
        _stockService = stockService;
    }

    // GET: api/StockController/GetProductList
    [HttpGet]
    public ListProductDto GetProductList()
    {
        return _stockService.GetProductList();
    }

    // POST api/StockController/GetProduct
    [HttpPost]
    public ProductModel? GetProduct([FromBody] ActionProductDto product)
    {
        return _stockService.GetProduct(product);
    }

    // POST api/StockController/AddProduct
    [HttpPost]
    public IActionResult AddProduct([FromBody] ProductModel product)
    {
        ResultModel result = _stockService.Add(product);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    // DELETE api/StockController/ClearStock
    [HttpDelete]
    public void ClearStock()
    {
        _stockService.Clear();
    }

    // POST api/StockController/DeleteProduct
    [HttpPost]
    public IActionResult DeleteProduct([FromBody] ActionProductDto product)
    {
        ResultModel result = _stockService.Remove(product);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    // POST api/StockController/AddProductCnt
    [HttpPost]
    public IActionResult AddProductCnt([FromBody] ChangeProductCountDto product)
    {
        ResultModel result = _stockService.AddProductCount(product);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    // POST api/StockController/RemoveProductCnt
    [HttpPost]
    public IActionResult RemoveProductCnt([FromBody] ChangeProductCountDto product)
    {
        ResultModel result = _stockService.RemoveProductCnt(product);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    // POST api/StockController/Save
    [HttpPost]
    public void Save()
    {
        _stockService.Save();
    }
}