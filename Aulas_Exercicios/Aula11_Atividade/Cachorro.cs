﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Atividade
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
         //   this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            base.Caracteristicas();
            Console.WriteLine("O som emitido pelo cachorro é: LATIDO\n\n");
        }
    }
}
