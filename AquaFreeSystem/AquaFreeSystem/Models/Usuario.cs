﻿using AquaFreeSystem.Dtos;
using System.ComponentModel.DataAnnotations;

namespace AquaFreeSystem.Models
{
    //Waldo Gustavo Davalos Terceros
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
}
