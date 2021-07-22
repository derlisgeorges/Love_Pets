using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class DonoRepository : IDonoRepository
    {

        /// <summary>
        /// Instancia o objeto ctx com a classe lovePetsContext
        /// </summary>
        lovePetsContext ctx = new lovePetsContext();

        public void Atualizar(int idDono, Dono DonoAtualizado)
        {
            Dono DonoBuscado = BuscarPorId(idDono);

            if (DonoAtualizado.NomeDono != null)
            {
                DonoBuscado.NomeDono = DonoAtualizado.NomeDono;
            }
        }

        public Dono BuscarPorId(int idDono)
        {
            return ctx.Donos.Find(idDono);
        }

        public void Cadastrar(Atendimento novoDono)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idDono)
        {
            ctx.Donos.Remove(BuscarPorId(idDono));

            ctx.SaveChanges();
        }

        public List<Dono> ListarTodos()
        {
            return ctx.Donos.ToList();
        }
    }
}
