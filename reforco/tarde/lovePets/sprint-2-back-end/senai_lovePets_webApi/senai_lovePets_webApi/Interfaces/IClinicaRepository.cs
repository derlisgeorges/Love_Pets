using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IClinicaRepository
    {

        /// <summary>
        /// Lista todas as clinica
        /// </summary>
        /// <returns>Uma lista de clinica</returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Busca uma clinica através do seu ID
        /// </summary>
        /// <param name="idClinica">ID da clinica que será buscado</param>
        /// <returns>Uma clinica encontrada</returns>
        Clinica BuscarPorId(int idClinica);

        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto com as novas informações</param>
        void Cadastrar(Clinica novaClinica);

        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="idClinica">ID da clinica que será atualizado</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        void Atualizar(int idClinica, Clinica ClinicaAtualizada);

        /// <summary>
        /// Deleta uma clinica existente
        /// </summary>
        /// <param name="idClinica">ID da clinica que será deletado</param>
        void Deletar(int idClinica);
    }
}
