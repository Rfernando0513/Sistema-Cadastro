using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Cadastro
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario() {Nome = "Fernando", Senha = "abc123"},
            new Usuario() {Nome= "Samira", Senha = "123abc"},
            new Usuario() {Nome = "Edmar", Senha = "abc123"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string Senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (nome == usuario.Nome && usuario.Senha == Senha) {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
