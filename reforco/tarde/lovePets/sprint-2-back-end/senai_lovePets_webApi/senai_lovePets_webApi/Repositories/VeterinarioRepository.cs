using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {

        /// <summary>
        /// Instancia o objeto ctx com a classe lovePetsContext
        /// </summary>
        lovePetsContext ctx = new lovePetsContext();

        public void Atualizar(int idVeterinario, Veterinario VeterinarioAtualizado)
        {
            Veterinario VeterinarioBuscado = BuscarPorId(idVeterinario);

            if (VeterinarioAtualizado.IdClinica > 0)
            {
                VeterinarioBuscado.IdClinica = VeterinarioAtualizado.IdClinica;
            }

            if (VeterinarioAtualizado.IdUsuario > 0)
            {
                VeterinarioBuscado.IdUsuario = VeterinarioAtualizado.IdUsuario;
            }

            if (VeterinarioAtualizado.Crmv != null)
            {
                VeterinarioBuscado.Crmv = VeterinarioAtualizado.Crmv;
            }

            if (VeterinarioAtualizado.NomeVeterinario != null)
            {
                VeterinarioBuscado.NomeVeterinario = VeterinarioAtualizado.NomeVeterinario;
            }

            ctx.Veterinarios.Update(VeterinarioBuscado);

            ctx.SaveChanges();

        }

        public Veterinario BuscarPorId(int idVeterinario)
        {
            return ctx.Veterinarios.Find(idVeterinario);
        }

        public void Cadastrar(Veterinario novoVeterinario)
        {
            ctx.Veterinarios.Add(novoVeterinario);

            ctx.SaveChanges();
        }

        public void Deletar(int idVeterinario)
        {
            ctx.Veterinarios.Remove(BuscarPorId(idVeterinario));

            ctx.SaveChanges();
        }

        public List<Veterinario> ListarTodos()
        {
            return ctx.Veterinarios.ToList();
        }
    }
}
