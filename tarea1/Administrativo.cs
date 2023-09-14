using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Administrativo : empleados

    {
        public string oficina { get; set; }
        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("guardado");

        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            oficina = null;
            Console.WriteLine("borrado");
        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");

        }

        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            Console.WriteLine("oficina: {0}", oficina);
        }
    }
}
