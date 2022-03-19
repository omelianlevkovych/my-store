using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Application.Products;
using Store.Database;
using Store.UI.Models;

namespace Store.UI.Pages;

public class IndexModel : PageModel
{

    private readonly ApplicationDbContext context;

    public IndexModel(ApplicationDbContext context)
    {
        this.context = context;
    }

    [BindProperty]
    public ProductViewModel Product {get; set; }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPost()
    {
        await new CreateProduct(context).Do(Product.Name, Product.Description);
        return RedirectToPage("Index");
    }
}
