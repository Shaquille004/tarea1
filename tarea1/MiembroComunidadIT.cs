using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal interface MiembroComunidadIT
    {
        void Guardar(MiembroDeLaComunidad miembro);
        void Modificar(MiembroDeLaComunidad miembro);
        void obtener(MiembroDeLaComunidad miembro);
        void Borrar(MiembroDeLaComunidad miembro);
         

    }
}
