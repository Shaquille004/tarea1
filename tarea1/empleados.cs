using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public class empleados : MiembroDeLaComunidad

    {
        public string Cargo { get; set; }
        public int experiencia { get; set; }
        public double sueldo { get; set; }

        public override void Guardar(MiembroDeLaComunidad miembro)
        {
            base.Guardar(miembro);
            Console.WriteLine("guardado");
        }

        public override void obtener(MiembroDeLaComunidad miembro)
        {
            base.obtener(miembro);
            Console.WriteLine("sueldo: {0}", sueldo);
            Console.WriteLine("Cargo:{0}", Cargo);
            Console.WriteLine("experiencia: {0}", experiencia);
        }

        public override void Borrar(MiembroDeLaComunidad miembro)
        {
            base.Borrar(miembro);
            Cargo = null;
            sueldo = 0;
            experiencia = 0;
            Console.WriteLine("Borrar");
        }

        public override void Modificar(MiembroDeLaComunidad miembro)
        {
            base.Modificar(miembro);
            Console.WriteLine("modificado");
        }
    }
}
