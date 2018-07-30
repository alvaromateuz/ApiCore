using System;

namespace Dominio
{
    public class Catalogo : ICatalogo
    {
        public string RetornaCatalogo()
        {
            return "camiseta, calça jeans, bota, sapato, jaqueta";
        }

        public string CriarCatalogo()
        {
            return "Catálogo criado com sucesso!";
        }
    }
}
