using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Domain.Models;

public partial class Usuario
{
   

    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefono { get; set; }

    public int RolId { get; set; }

    public string Contrasena { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Cita> CitaClientes { get; set; } = new List<Cita>();

    public virtual ICollection<Cita> CitaEstilista { get; set; } = new List<Cita>();

    public virtual ICollection<Reseña> ReseñaClientes { get; set; } = new List<Reseña>();

    public virtual ICollection<Reseña> ReseñaEstilista { get; set; } = new List<Reseña>();

    public virtual Role Rol { get; set; } = null!;
}
