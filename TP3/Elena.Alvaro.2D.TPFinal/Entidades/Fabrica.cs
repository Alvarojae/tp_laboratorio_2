﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica<T> where T : Producto
    {
        public string nombre;
        public List<T> Listaproductos;

        public Fabrica()
        {
            this.Listaproductos = new List<T>();
        }

        public Fabrica(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Fabrica<T> lista, T item)
        {
            lista.Listaproductos.Add(item);
            return true;
        }
    }
}
