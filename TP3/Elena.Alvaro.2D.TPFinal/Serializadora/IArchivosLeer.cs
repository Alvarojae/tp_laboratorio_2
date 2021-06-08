using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializadora
{
    public interface IArchivosLeer<T>
    {
            bool Leer(string archivo, out T datos);
    }
}
