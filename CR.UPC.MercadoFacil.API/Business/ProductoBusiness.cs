using System;
using CR.UPC.MercadoFacil.API.Data;
using CR.UPC.MercadoFacil.API.Models;

namespace CR.UPC.MercadoFacil.API.Business;

public class ProductoBusiness
{
    private readonly ProductoData _productoData;

    public ProductoBusiness(ProductoData productoData)
    {
        _productoData = productoData;
    }

    public async Task<IEnumerable<ProductoCatalogoModel>> GetProductosCatalogo(int idCategoria = 0, string? nombre = null)
    {
        if (!string.IsNullOrEmpty(nombre))
        {
            return await _productoData.GetProductosCatalogoPorNombre(nombre);
        }
        if (idCategoria > 0)
        {
            return await _productoData.GetProductosCatalogoPorCategoria(idCategoria);
        }
        return await _productoData.GetProductosCatalogo();
    }
}
