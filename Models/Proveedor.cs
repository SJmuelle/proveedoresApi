namespace ProveedoresApi.Models
{
    public class Proveedor
    {
        public string Id { get; set; } = string.Empty;
        public string NIT { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string NombreContacto { get; set; } = string.Empty;
        public string CorreoContacto { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;
        public string TipoProveedor { get; set; } = string.Empty;
    }
}

