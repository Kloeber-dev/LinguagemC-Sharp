﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    class Gato : Mamifero
    {
        public Gato()
        {
            //    this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.WriteLine("São animais endotérmicos que possuem pelos e glândulas mamárias");
            Console.WriteLine("O som emitido pelo gato é: MIADO\n\n");
        }
    }
}
