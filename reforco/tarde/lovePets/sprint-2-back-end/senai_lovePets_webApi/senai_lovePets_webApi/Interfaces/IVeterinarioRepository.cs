using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IVeterinarioRepository
    {

        /// <summary>
        /// Lista todos os Veterinario
        /// </summary>
        /// <returns>Uma lista de Veterinario</returns>
        List<Veterinario> ListarTodos();

        /// <summary>
        /// Busca um Veterinario através do seu ID
        /// </summary>
        /// <param name="idVeterinario">ID do Veterinario que será buscado</param>
        /// <returns>Um Veterinario encontrado</returns>
        Veterinario BuscarPorId(int idVeterinario);

        /// <summary>
        /// Cadastra um novo Veterinario
        /// </summary>
        /// <param name="novoVeterinario">Objeto com as novas informações</param>
        void Cadastrar(Veterinario novoVeterinario);

        /// <summary>
        /// Atualiza um Veterinario existente
        /// </summary>
        /// <param name="idVeterinario">ID do Veterinario que será atualizado</param>
        /// <param name="VeterinarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idVeterinario, Veterinario VeterinarioAtualizado);

        /// <summary>
        /// Deleta um Veterinario existente
        /// </summary>
        /// <param name="idVeterinario">ID do Veterinario que será deletado</param>
        void Deletar(int idVeterinario);

    }
}
