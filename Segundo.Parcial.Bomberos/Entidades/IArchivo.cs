﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<X>
    {
        public X Leer();
        public void Guardar(X info);
    }
}
