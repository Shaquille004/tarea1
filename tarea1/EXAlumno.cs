using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public class EXAlumno : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public string matricula { get; set; }
        public DateTime graduacion { get; set; }

        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Guardado");

        }

        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            Console.WriteLine("Matricula: {0}", matricula);
            Console.WriteLine("Carrera: {0}", Carrera);
            Console.WriteLine("graduacion: {0}", graduacion);

        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");

        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            matricula = null;
            Carrera = null;
            Console.WriteLine("Borrado");
        }
    }
}
