﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaCore.BO.Response
{
    public class ResponseStatus
    {
        public static readonly ResponseStatus SUCESSO = new ResponseStatus(0, "SUCESSO");
        public static readonly ResponseStatus FALHA = new ResponseStatus(1, "FALHA");        

        private int _codigo;
        private string _txt;

        private ResponseStatus(int codigo, string txt)
        {
            _codigo = codigo;
            _txt = txt;
        }

        public ResponseStatus()
        {
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string Texto
        {
            get
            {
                return _txt;
            }

            set
            {
                _txt = value;
            }
        }
    }
}
