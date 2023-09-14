using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public class Estudiantes : MiembroDeLaComunidad
    {
        public string matricula { get; set; }
        public string carrera { get; set; }
        public DateTime Ingreso { get; set; }



        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Guardado");
        }

        public override void obtener (MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            Console.WriteLine("matricula: {0}", matricula);
            Console.WriteLine("ingreso: {0}", Ingreso);
            Console.WriteLine("carrera: {0}", carrera);
        }

        public override void Modificar (MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");
        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            matricula = null;
            carrera = null;
            Console.WriteLine("borrado");

        }
    }
}