using System;
using System.Collections.Generic;
using SegundoParcial.Models;

namespace SegundoParcial.Dato
{
    class Usuario
    {
        List<Citi> listaH = new List<Citi>();

        //Guardar los usuarios
        public void Guardar(Citi modeloC)
        {
            if (modeloC != null)
                listaH.Add(modeloC);
        }

        //Consulta todos los usuarios

        public List<Citi> ConsultarH()
        {
            return listaH;
        }

        public void Limpiar()
        {
            listaH.Clear();
        }
    }
}
