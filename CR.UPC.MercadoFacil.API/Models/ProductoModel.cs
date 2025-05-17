using System;

namespace CR.UPC.MercadoFacil.API.Models;

public class ProductoModel
{
    public int idProducto { get; set; }
    public string SKU { get; set; } = string.Empty;
    public string nombre { get; set; } = string.Empty;
    public int idproductoMarca { get; set; }
    public int idProductoCategoria { get; set; }
    public string imagen { get; set; } = string.Empty;
}
