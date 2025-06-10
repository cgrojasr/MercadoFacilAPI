using System;
using CR.UPC.MercadoFacil.API.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CR.UPC.MercadoFacil.API.Data;

public class ProductoCategoriaData
{
    private readonly string _connectionString = string.Empty;
    public ProductoCategoriaData(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("dbMercadoFacil") ?? string.Empty;
    }

    public async Task<IEnumerable<CategoriaListarModel>> CategoriaListar()
    {
        IEnumerable<CategoriaListarModel> categorias;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT idProductoCategoria, nombre FROM ProductoCategoria";
            categorias = await connection.QueryAsync<CategoriaListarModel>(query);
        }
        return categorias;
    }
}
