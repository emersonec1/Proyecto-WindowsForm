using System;
using System.Collections.Generic;

namespace proyectobiblioteca.Models;

public partial class Lector
{
    public int IdLector { get; set; }

    public string Run { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Fono { get; set; }

    public string Direccion { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
