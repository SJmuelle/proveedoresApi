using ProveedoresApi.Models;

namespace ProveedoresApi.Repositories
{
    public interface IProveedorRepository
    {
        Task<List<Proveedor>> GetAllAsync();
        Task<Proveedor?> GetByIdAsync(string id);
        Task CreateAsync(Proveedor proveedor);
        Task UpdateAsync(string id, Proveedor proveedor);
        Task DeleteAsync(string id);
    }
}
