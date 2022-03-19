using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Application.Products.Create;
using Store.Application.Products.Get;
using Store.Database;

namespace Store.UI.Pages;

public class IndexModel : PageModel
{

    private readonly ApplicationDbContext context;

    public IndexModel(ApplicationDbContext context)
    {
        this.context = context;
    }

    [BindProperty]
    public CreateProductModel Product {get; set; }

    public IEnumerable<GetProductModel> Products { get; set; }

    public async Task OnGet()
    {
        Products = await new GetProducts(context).Do();
    }

    public async Task<IActionResult> OnPost()
    {
        await new CreateProduct(context).Do(Product);
        return RedirectToPage("Index");
    }
}
