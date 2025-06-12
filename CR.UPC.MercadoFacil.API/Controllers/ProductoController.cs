using CR.UPC.MercadoFacil.API.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CR.UPC.MercadoFacil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoBusiness _productoBusiness;

        public ProductoController(ProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
        }

        [HttpGet("GetProductosCatalogo/{idCategoria}/{nombre?}")]
        public async Task<IActionResult> GetProductosCatalogo(int idCategoria = 0, string? nombre = null)
        {
            try
            {
                var productos = await _productoBusiness.GetProductosCatalogo(idCategoria, nombre);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
