using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Produto : IProduto
    {
        ICatalogo _catalogo;
        public Produto(ICatalogo catalogo)
        {
            _catalogo = catalogo;
        }

        public string RetornaProduto(int index)
        {
            var retorno = _catalogo.RetornaCatalogo()[index];
            return retorno;
        }
    }
}
