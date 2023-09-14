using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public class Maestro : Docente 

       
    {
        public List<string> Instituto { get; set; }



        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("Guardado");
        }

        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            foreach (string institutos in Instituto)
            {
                Console.WriteLine("intitutos:{0}", Instituto);
            }
        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("Modificado");
        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            Instituto = null;
            proyectos = null;
            Console.WriteLine("Borrado");
        }

    }
}



