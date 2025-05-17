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

    public async Task<IEnumerable<ProductoCatalogoModel>> GetProductosCatalogo()
    {
        return await _productoData.GetProductosCatalogo();
    }
}
