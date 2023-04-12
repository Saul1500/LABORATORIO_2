using NotaEstudiante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaEstudiante.DAO
{
    public class Operaciones
    {
        decimal Resultado1;
        decimal Resultado2;
        decimal Resultado3;
        decimal ponderacionLa = 0.4M;
        decimal ponderacionPa = 0.6M;
        public decimal Periodos(Notum nota)
        {
           Resultado1 = nota.Labo1 * ponderacionLa + nota.Parcial1 * ponderacionPa;  
           Resultado2 = nota.Labo2 * ponderacionLa + nota.Parcial2 * ponderacionPa;
           Resultado3 = nota.Labo3 * ponderacionLa + nota.Parcial3 * ponderacionPa;
           nota.Resultado.ToString("F1");
           return nota.Resultado = (Resultado1 + Resultado2 + Resultado3) / 3;
        }

        public void AgregarNota(Notum ParamentrosNota)
        {

            using (NotaEstudianteContext db =
                new NotaEstudianteContext())
            {
                Notum operaciones = new Notum();
                operaciones.Materia = ParamentrosNota.Materia;
                operaciones.NombreEstudiante = ParamentrosNota.NombreEstudiante;
                operaciones.Labo1 = ParamentrosNota.Labo1;
                operaciones.Parcial1 = ParamentrosNota.Parcial1;
                operaciones.Labo2 = ParamentrosNota.Labo2;
                operaciones.Parcial2 = ParamentrosNota.Parcial2;
                operaciones.Labo3 = ParamentrosNota.Labo3;
                operaciones.Parcial3 = ParamentrosNota.Parcial3;
                operaciones.Resultado = ParamentrosNota.Resultado;
                db.Add(operaciones);
                db.SaveChanges();
            }     
        }
        public List<Notum> ListarNotas() 
        {
            using (NotaEstudianteContext db =
           new NotaEstudianteContext())
            {
                return db.Nota.ToList();
            }

        }
    }
}





