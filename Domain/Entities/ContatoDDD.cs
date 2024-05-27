﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContatoDDD
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DDD DDD { get; set; }
    }
}
