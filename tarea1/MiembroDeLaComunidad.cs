using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    public abstract class MiembroDeLaComunidad : MiembroComunidadIT
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int edad { get; set; }

        public virtual void Guardar(MiembroDeLaComunidad miembro)
        {
            Console.WriteLine("");
        }

        public virtual void obtener (MiembroDeLaComunidad miembro)
        {
            Console.WriteLine("nombres: {0}", Nombre);
            Console.WriteLine("apellido:{0}", Apellido);
            Console.WriteLine("Edad: {0}", edad);
        }

        public virtual void Modificar (MiembroDeLaComunidad miembro)
        {
            Console.WriteLine("");
        }

        public virtual void Borrar (MiembroDeLaComunidad miembro)
        {
            Nombre = null;
            Apellido = null;
            edad = 0;


        }
       
        
    }
}
