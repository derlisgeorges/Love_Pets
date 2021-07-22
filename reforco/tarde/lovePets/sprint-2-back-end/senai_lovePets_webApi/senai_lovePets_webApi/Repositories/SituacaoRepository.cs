﻿using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {

        /// <summary>
        /// Instancia o objeto ctx com a classe lovePetsContext
        /// </summary>
        lovePetsContext ctx = new lovePetsContext();

        public void Atualizar(int idSituacao, Situacao SituacaoAtualizada)
        {

            Situacao SituacaoBuscada = BuscarPorId(idSituacao);

            if (SituacaoAtualizada.NomeSituacao != null)
            {
                SituacaoBuscada.NomeSituacao = SituacaoAtualizada.NomeSituacao;
            }

            ctx.Situacaos.Update(SituacaoBuscada);

            ctx.SaveChanges();
        }

        public Situacao BuscarPorId(int idSituacao)
        {
            return ctx.Situacaos.Find(idSituacao);
        }

        public void Cadastrar(Situacao novaSituacao)
        {
            ctx.Situacaos.Add(novaSituacao);

            ctx.SaveChanges();
        }

        public void Deletar(int idSituacao)
        {
            ctx.Situacaos.Remove(BuscarPorId(idSituacao));

            ctx.SaveChanges();
        }

        public List<Situacao> ListarTodos()
        {
            return ctx.Situacaos.ToList();
        }
    }
}
