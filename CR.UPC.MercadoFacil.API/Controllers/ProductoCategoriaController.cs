using CR.UPC.MercadoFacil.API.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CR.UPC.MercadoFacil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoCategoriaController : ControllerBase
    {
        private readonly ProductoCategoriaBusiness _productoCategoriaBusiness;

        public ProductoCategoriaController(ProductoCategoriaBusiness productoCategoriaBusiness)
        {
            _productoCategoriaBusiness = productoCategoriaBusiness;
        }

        // [HttpGet("CategoriaListar")]
        [HttpGet]
        public async Task<IActionResult> CategoriaListar()
        {
            var categorias = await _productoCategoriaBusiness.CategoriaListar();
            return Ok(categorias);
        }
    }
}
