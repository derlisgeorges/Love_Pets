using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoPetRepository
    {
        /// <summary>
        /// Lista todos os atendimentos
        /// </summary>
        /// <returns>Uma lista de atendimentos</returns>
        List<TipoPet> ListarTodos();

        /// <summary>
        /// Busca um atendimento através do seu ID
        /// </summary>
        /// <param name="idTipoPet">ID do atendimento que será buscado</param>
        /// <returns>Um atendimento encontrado</returns>
        TipoPet BuscarPorId(int idTipoPet);

        /// <summary>
        /// Cadastra um novo atendimento
        /// </summary>
        /// <param name="novoTipoPet">Objeto com as novas informações</param>
        void Cadastrar(TipoPet novoTipoPet);

        /// <summary>
        /// Atualiza um atendimento existente
        /// </summary>
        /// <param name="idTipoPet">ID do atendimento que será atualizado</param>
        /// <param name="TipoPetAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idTipoPet, TipoPet TipoPetAtualizado);

        /// <summary>
        /// Deleta um atendimento existente
        /// </summary>
        /// <param name="idTipoPet">ID do atendimento que será deletado</param>
        void Deletar(int idTipoPet);


    }
}
