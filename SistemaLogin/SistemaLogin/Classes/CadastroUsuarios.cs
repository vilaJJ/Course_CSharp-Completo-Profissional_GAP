using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Classes
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario()
            {
                Nome = "Juan",
                Senha = "123123"
            },
            new Usuario()
            {
                Nome = "Yasmin",
                Senha = "123456"
            },
            new Usuario()
            {
                Nome = "Madu",
                Senha = "duda"
            }
        };

        private static Usuario usuario_logado = null;
        
        public static Usuario UsuarioLogado
        {
            get
            {
                return usuario_logado;
            }
            private set
            {
                usuario_logado = value;
            }
        }

        public static bool Login(Usuario usuario)
        {
            foreach (Usuario u in usuarios)
            {
                if (usuario.Nome == u.Nome && usuario.Senha == u.Senha)
                {
                    UsuarioLogado = u;
                    return true;
                }
            }
            return false;
        }
    }
}
