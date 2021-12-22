using Catalogs.API.Entities;
using MongoDB.Driver;

namespace Catalogs.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
