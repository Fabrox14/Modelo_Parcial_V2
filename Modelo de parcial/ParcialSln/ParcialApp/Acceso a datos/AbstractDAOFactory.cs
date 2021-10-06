﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialApp.Acceso_a_datos
{
    abstract class AbstractDAOFactory
    {
        public abstract IFacturaDAO CrearFacturaDAO();
    }
}
