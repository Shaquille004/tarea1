using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class administrador : Docente
    {
        public List<string> proyectos { get; set; }
        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("guardado");

        }
        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            foreach (string Proyectos in proyectos)
            {
                Console.WriteLine("proyectos: {0}", Proyectos);
            }
        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");
        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            base.proyectos = null;
            Console.WriteLine("borrado");
        }
    }
}
