using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IRacaRepository
    {
        /// <summary>
        /// Lista todos as raça
        /// </summary>
        /// <returns>Uma lista de raça</returns>
        List<Raca> ListarTodos();

        /// <summary>
        /// Busca uma raça através do seu ID
        /// </summary>
        /// <param name="idRaca">ID da raça que será buscado</param>
        /// <returns>Uma raça encontrado</returns>
        Raca BuscarPorId(int idRaca);

        /// <summary>
        /// Cadastra um nova raça
        /// </summary>
        /// <param name="novaRaca">Objeto com as novas informações</param>
        void Cadastrar(Raca novaRaca);

        /// <summary>
        /// Atualiza uma raça existente
        /// </summary>
        /// <param name="idRaca">ID da raça que será atualizado</param>
        /// <param name="RacaAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idRaca, Raca RacaAtualizado);

        /// <summary>
        /// Deleta uma raça existente
        /// </summary>
        /// <param name="idRaca">ID da raça que será deletado</param>
        void Deletar(int idRaca);


    }
}
