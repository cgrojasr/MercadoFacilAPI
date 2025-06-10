using System;
using CR.UPC.MercadoFacil.API.Data;
using CR.UPC.MercadoFacil.API.Models;

namespace CR.UPC.MercadoFacil.API.Business;

public class ProductoCategoriaBusiness
{
    private readonly ProductoCategoriaData _productoCategoriaData;

    public ProductoCategoriaBusiness(ProductoCategoriaData productoCategoriaData)
    {
        _productoCategoriaData = productoCategoriaData;
    }

    public async Task<IEnumerable<CategoriaListarModel>> CategoriaListar()
    {
        return await _productoCategoriaData.CategoriaListar();
    }
}
