﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class Mensaje
    {
        public abstract IMensaje CrearMensaje();

        public void notificacion(string mensaje)
        {
            var msg = CrearMensaje();
            msg.EnviarMensaje(mensaje);
        }
    }
}