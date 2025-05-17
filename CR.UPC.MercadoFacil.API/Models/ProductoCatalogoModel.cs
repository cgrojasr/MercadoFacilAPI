using System;

namespace CR.UPC.MercadoFacil.API.Models;

public class ProductoCatalogoModel
{
    public int idProducto { get; set; }
    public string SKU { get; set; } = string.Empty;
    public string nombre { get; set; } = string.Empty;
    public string marca { get; set; } = string.Empty;
    public string imagen { get; set; } = string.Empty;
}
