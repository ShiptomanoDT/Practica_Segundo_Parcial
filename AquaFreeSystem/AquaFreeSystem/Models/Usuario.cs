using AquaFreeSystem.Dtos;

namespace AquaFreeSystem.Models
{
    //Waldo Gustavo Davalos Terceros
    public class Usuario
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Password { get; set; }
        public RolEnum Rol { get; set; }
    }
}
