using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Busca um usuário existente
        /// </summary>
        /// <param name="email">O e-mail que o usuário digitou</param>
        /// <param name="senha">A senha que o usuário digitou</param>
        /// <returns>Um usuário encontrado</returns>
        Usuario BuscarPorEmailSenha(string email, string senha);
    }
}
