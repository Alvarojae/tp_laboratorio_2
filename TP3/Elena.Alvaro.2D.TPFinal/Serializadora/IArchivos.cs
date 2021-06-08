using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializadora
{
    public interface IArchivos<T>
    {
        T Leer(string archivo);
  
        bool Guardar(string archivo, T datos);

    }
}
