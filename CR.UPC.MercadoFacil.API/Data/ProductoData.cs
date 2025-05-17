using System;
using System.Runtime.CompilerServices;
using CR.UPC.MercadoFacil.API.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CR.UPC.MercadoFacil.API.Data;

public class ProductoData
{
    private readonly string _connectionString = string.Empty;
    public ProductoData(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("dbMercadoFacil") ?? string.Empty;
    }

    public async Task<IEnumerable<ProductoCatalogoModel>> GetProductosCatalogo()
    {
        IEnumerable<ProductoCatalogoModel> productos;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT PRO.idProducto, PRO.SKU, PRO.nombre, MAR.nombre AS marca, PRO.imagen "+
                            "FROM Producto PRO "+
                            "INNER JOIN ProductoMarca MAR ON PRO.idproductoMarca = MAR.idProductoMarca ";
            productos = await connection.QueryAsync<ProductoCatalogoModel>(query);
        }
        return productos;
    }   
}
