using System;
using System.Collections.Generic;

namespace proyectobiblioteca.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string? Editorial { get; set; }

    public string? Isbn { get; set; }

    public int AñoPublicacion { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
