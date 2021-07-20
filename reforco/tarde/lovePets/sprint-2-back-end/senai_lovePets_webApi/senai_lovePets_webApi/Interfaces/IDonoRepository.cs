using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IDonoRepository
    {
        /// <summary>
        /// Lista todos os donos
        /// </summary>
        /// <returns>Uma lista de donos</returns>
        List<Dono> ListarTodos();

        /// <summary>
        /// Busca um dono através do seu ID
        /// </summary>
        /// <param name="idDono">ID do dono que será buscado</param>
        /// <returns>Um dono encontrado</returns>
        Dono BuscarPorId(int idDono);

        /// <summary>
        /// Cadastra um novo dono
        /// </summary>
        /// <param name="novoDono">Objeto com as novas informações</param>
        void Cadastrar(Atendimento novoDono);

        /// <summary>
        /// Atualiza um dono existente
        /// </summary>
        /// <param name="idDono">ID do dono que será atualizado</param>
        /// <param name="DonoAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idDono, Dono DonoAtualizado);

        /// <summary>
        /// Deleta um dono existente
        /// </summary>
        /// <param name="idDono">ID do dono que será deletado</param>
        void Deletar(int idDono);
    }
}
