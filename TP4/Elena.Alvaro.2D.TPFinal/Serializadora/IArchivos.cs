using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializadora
{
    public interface IArchivos<T>
    {
        bool Guardar(string archivo, T datos);

        T Leer(string archivo);
    }
}
