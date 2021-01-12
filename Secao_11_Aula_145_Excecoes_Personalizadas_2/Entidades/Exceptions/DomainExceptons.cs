using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_11_Aula_145_Excecoes_Personalizadas_2.Entidades.Exceptions
{
    class DomainExceptons : ApplicationException
    {
        public DomainExceptons(string message) : base(message)
        {
        }

    }
}
