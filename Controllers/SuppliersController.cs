using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mormordagnysbageri_del1_api.Data;
using mormordagnysbageri_del1_api.Entities;

namespace mormordagnysbageri_del1_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuppliersController(DataContext context) : ControllerBase
{
    private readonly DataContext _context = context;

    [HttpGet()]
    public async Task<ActionResult> ListAllSuppliers(){
        var suppliers = await _context.Suppliers
        .Include(sp => sp.SupplierIngredients) 
        .Select(supplier => new {
            supplier.Name,
            supplier.ContactPerson,
            supplier.Email,
            supplier.Phone,
            Ingredients = supplier.SupplierIngredients
                .Select(SupplierIngredient => new {
                SupplierIngredient.Ingredient.Name,
                SupplierIngredient.ItemNumber,
                SupplierIngredient.Price
            })
        })
        .ToListAsync();
        return Ok(new { success = true, StatusCode = 200, data = suppliers });
    }
  

    [HttpGet("{id}")]
    public async Task<ActionResult> FindSupplier (int id){
        var supplier = await _context.Suppliers
        .Where(s => s.Id == id)
        .Include(sp => sp.SupplierIngredients) 
        .Select(supplier => new {
            supplier.Name,
            supplier.ContactPerson,
            supplier.Email,
            supplier.Phone,
            Ingredients = supplier.SupplierIngredients
                .Select(SupplierIngredient => new {
                SupplierIngredient.Ingredient.Name,
                SupplierIngredient.ItemNumber,
                SupplierIngredient.Price
            })
        })
        .SingleOrDefaultAsync();
     

            if(supplier is null){
                return NotFound(new {success = false, StatusCode = 404, message = $"Tyvärr, vi kunde inte hitta någon leverantör med id: {id}" });
            }
            return Ok(new {success = true, StatusCode = 200, data = supplier});
    


    }

}
