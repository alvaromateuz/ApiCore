using System;

namespace Dominio
{
    public class Catalogo : ICatalogo
    {
        public string[] RetornaCatalogo()
        {
            return new string[] { "camiseta", "calça jeans", "bota", "sapato", "jaqueta", "tênis" };
        }

        public string CriarCatalogo()
        {
            return "Catálogo criado com sucesso!";
        }
    }
}
