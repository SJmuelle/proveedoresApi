using Microsoft.AspNetCore.Mvc;
using ProveedoresApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace ProveedoresApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProveedoresController : ControllerBase
    {
        // Mock estático para simular una base de datos en memoria
        private static List<Proveedor> _proveedores = new List<Proveedor>
        {
            new Proveedor
            {
                Id = "1",
                NIT = "123456789",
                RazonSocial = "Proveedor 1 S.A.S.",
                Direccion = "Calle Falsa 123",
                Ciudad = "Bogotá",
                Departamento = "Cundinamarca",
                Correo = "proveedor1@example.com",
                NombreContacto = "Juan Pérez",
                CorreoContacto = "juan.perez@example.com",
                Telefono = "3216549870",
                TipoProveedor = "Servicios"
            },
            new Proveedor
            {
                Id = "2",
                NIT = "987654321",
                RazonSocial = "Proveedor 2 Ltda.",
                Direccion = "Carrera 45 #67-89",
                Ciudad = "Medellín",
                Departamento = "Antioquia",
                Correo = "proveedor2@example.com",
                NombreContacto = "María López",
                CorreoContacto = "maria.lopez@example.com",
                Telefono = "3109876543",
                TipoProveedor = "Suministros"
            }
        };

        // GET: api/proveedores
        [HttpGet]
        public IActionResult Get() => Ok(_proveedores);

        // GET: api/proveedores/1
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var proveedor = _proveedores.FirstOrDefault(p => p.Id == id);
            return proveedor != null ? Ok(proveedor) : NotFound();
        }

        // POST: api/proveedores
        [HttpPost]
        public IActionResult Create([FromBody] Proveedor proveedor)
        {
            proveedor.Id = Guid.NewGuid().ToString();
            _proveedores.Add(proveedor);
            return CreatedAtAction(nameof(GetById), new { id = proveedor.Id }, proveedor);
        }

        // PUT: api/proveedores/1
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Proveedor updated)
        {
            var proveedor = _proveedores.FirstOrDefault(p => p.Id == id);
            if (proveedor == null) return NotFound();

            // Actualizar campos
            proveedor.NIT = updated.NIT;
            proveedor.RazonSocial = updated.RazonSocial;
            proveedor.Direccion = updated.Direccion;
            proveedor.Ciudad = updated.Ciudad;
            proveedor.Departamento = updated.Departamento;
            proveedor.Correo = updated.Correo;
            proveedor.NombreContacto = updated.NombreContacto;
            proveedor.CorreoContacto = updated.CorreoContacto;
            proveedor.Telefono = updated.Telefono;
            proveedor.TipoProveedor = updated.TipoProveedor;

            return NoContent();
        }

        // DELETE: api/proveedores/1
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var proveedor = _proveedores.FirstOrDefault(p => p.Id == id);
            if (proveedor == null) return NotFound();

            _proveedores.Remove(proveedor);
            return NoContent();
        }
    }
}
