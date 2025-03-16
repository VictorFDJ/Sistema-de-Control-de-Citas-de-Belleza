using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Domain.Models;

public partial class Reseña
{
    

    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int EstilistaId { get; set; }

    public int Calificacion { get; set; }

    public string? Comentario { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Usuario Cliente { get; set; } = null!;

    public virtual Usuario Estilista { get; set; } = null!;
}
