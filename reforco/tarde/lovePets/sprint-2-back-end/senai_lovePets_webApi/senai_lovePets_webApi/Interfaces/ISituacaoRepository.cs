using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ISituacaoRepository
    {
        /// <summary>
        /// Lista todas situação
        /// </summary>
        /// <returns>Uma lista de situação</returns>
        List<Situacao> ListarTodos();

        /// <summary>
        /// Busca uma situação através do seu ID
        /// </summary>
        /// <param name="idSituacao">ID da situação que será buscado</param>
        /// <returns>Uma situação encontrado</returns>
        Situacao BuscarPorId(int idSituacao);

        /// <summary>
        /// Cadastra um nova situcação
        /// </summary>
        /// <param name="novoSituacao">Objeto com as novas informações</param>
        void Cadastrar(Situacao novoSituacao);

        /// <summary>
        /// Atualiza uma situação existente
        /// </summary>
        /// <param name="idSituacao">ID da situação que será atualizado</param>
        /// <param name="SituacaoAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idSituacao, Situacao SituacaoAtualizado);

        /// <summary>
        /// Deleta uma situção existente
        /// </summary>
        /// <param name="idSituacao">ID da situação que será deletado</param>
        void Deletar(int idSituacao);

    }
}
