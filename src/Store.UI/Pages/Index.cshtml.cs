using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Application.Products.Interfaces;
using Store.Application.Products.Models;

namespace Store.UI.Pages;

public class IndexModel : PageModel
{

    private readonly IProductLogic productLogic;

    public IndexModel(IProductLogic productLogic)
    {
        this.productLogic = productLogic;
    }

    [BindProperty]
    public ProductModel Product { get; set; }

    public IEnumerable<ProductModel> Products { get; set; }

    public async Task OnGet()
    {
        Products = await productLogic.GetProducts();
    }

    public async Task<IActionResult> OnPost()
    {
        await productLogic.CreateProduct(Product);
        return RedirectToPage("Index");
    }
}
