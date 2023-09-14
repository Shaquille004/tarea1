using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public class Docente : empleados

    {
        public string proyectos { get; set; }
        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("guardado");
        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");

        }

        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            Console.WriteLine("materia: {0}", proyectos);

        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            proyectos = null;
            Console.WriteLine("borrado");
        }

    }
}
