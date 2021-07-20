using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        /// <summary>
        /// Lista todos os TipoUsuario
        /// </summary>
        /// <returns>Uma lista de TipoUsuario</returns>
        List<TipoUsuario> ListarTodos();

        /// <summary>
        /// Busca um TipoUsuario através do seu ID
        /// </summary>
        /// <param name="idTipoUsuario">ID do TipoUsuario que será buscado</param>
        /// <returns>Um TipoUsuario encontrado</returns>
        Atendimento BuscarPorId(int idTipoUsuario);

        /// <summary>
        /// Cadastra um novo atendimento
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto com as novas informações</param>
        void Cadastrar(TipoUsuario novoTipoUsuario);

        /// <summary>
        /// Atualiza um TipoUsuario existente
        /// </summary>
        /// <param name="idTipoUsuario">ID do TipoUsuario que será atualizado</param>
        /// <param name="TipoUsuarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um TipoUsuario existente
        /// </summary>
        /// <param name="idTipoUsuario">ID do TipoUsuario que será deletado</param>
        void Deletar(int idTipoUsuario);
    }
}
