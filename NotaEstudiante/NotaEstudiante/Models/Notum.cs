using System;
using System.Collections.Generic;

namespace NotaEstudiante.Models;

public partial class Notum
{
    public int Notas { get; set; }

    public string? Materia { get; set; }

    public string? NombreEstudiante { get; set; }

    public decimal Labo1 { get; set; }

    public decimal Parcial1 { get; set; }

    public decimal Labo2 { get; set; }

    public decimal Parcial2 { get; set; }

    public decimal Labo3 { get; set; }

    public decimal Parcial3 { get; set; }

    public decimal Resultado { get; set; }

}
