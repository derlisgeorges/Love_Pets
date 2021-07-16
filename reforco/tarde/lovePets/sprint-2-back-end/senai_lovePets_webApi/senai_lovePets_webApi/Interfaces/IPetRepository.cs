using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IPetRepository
    {
        /// <summary>
        /// Lista todos os pet
        /// </summary>
        /// <returns>Uma lista de pet</returns>
        List<Pet> ListarTodos();

        /// <summary>
        /// Busca um pet através do seu ID
        /// </summary>
        /// <param name="idPet">ID do pet que será buscado</param>
        /// <returns>Um pet encontrado</returns>
        Pet BuscarPorId(int idPet);

        /// <summary>
        /// Cadastra um novo pet
        /// </summary>
        /// <param name="novoPet">Objeto com as novas informações</param>
        void Cadastrar(Pet novoPet);

        /// <summary>
        /// Atualiza um pet existente
        /// </summary>
        /// <param name="idAtendimento">ID do pet que será atualizado</param>
        /// <param name="PetAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idAtendimento, Pet PetAtualizado);

        /// <summary>
        /// Deleta um pet existente
        /// </summary>
        /// <param name="idPet">ID do pet que será deletado</param>
        void Deletar(int idPet);

    }
}
