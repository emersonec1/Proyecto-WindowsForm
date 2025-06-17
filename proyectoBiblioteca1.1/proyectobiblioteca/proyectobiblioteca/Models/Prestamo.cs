using System;
using System.Collections.Generic;

namespace proyectobiblioteca.Models;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public int IdUsuario { get; set; }

    public int IdLector { get; set; }

    public DateOnly FechaPrestamo { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

    public int IdLibro { get; set; }

    public virtual Lector IdLectorNavigation { get; set; } = null!;

    public virtual Libro IdLibroNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
