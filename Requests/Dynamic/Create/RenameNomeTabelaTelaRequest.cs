﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic.Create
{
    public class RenameNomeTabelaTelaRequest
    {
        public int IdTabela {  get; set; }
        public string NovoNome { get; set; }
    }
}
