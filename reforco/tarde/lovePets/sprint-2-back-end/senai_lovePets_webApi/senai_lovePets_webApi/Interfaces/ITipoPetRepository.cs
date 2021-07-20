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
        /// Lista todos os tiposPet
        /// </summary>
        /// <returns>Uma lista de tiposPet</returns>
        List<TipoPet> ListarTodos();

        /// <summary>
        /// Busca um tiposPet através do seu ID
        /// </summary>
        /// <param name="idTipoPet">ID do tiposPet que será buscado</param>
        /// <returns>Um tiposPet encontrado</returns>
        TipoPet BuscarPorId(int idTipoPet);

        /// <summary>
        /// Cadastra um novo tiposPet
        /// </summary>
        /// <param name="novoTipoPet">Objeto com as novas informações</param>
        void Cadastrar(TipoPet novoTipoPet);

        /// <summary>
        /// Atualiza um tiposPet existente
        /// </summary>
        /// <param name="idTipoPet">ID do tiposPet que será atualizado</param>
        /// <param name="TipoPetAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idTipoPet, TipoPet TipoPetAtualizado);

        /// <summary>
        /// Deleta um tiposPet existente
        /// </summary>
        /// <param name="idTipoPet">ID do tiposPet que será deletado</param>
        void Deletar(int idTipoPet);

    }
}
