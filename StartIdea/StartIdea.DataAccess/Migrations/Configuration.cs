using StartIdea.Model;
using StartIdea.Model.ScrumArtefatos;
using StartIdea.Model.TimeScrum;
using System.Data.Entity.Migrations;

namespace StartIdea.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StartIdeaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StartIdeaDBContext context)
        {
            #region Usuarios
            context.Usuarios.AddOrUpdate(x => x.Id,
                new Usuario()
                {
                    Id = 1,
                    Email = "eltongarbin@gmail.com",
                    Senha = "oQ/OOuYzfK7mvK55NZJClHVCQj41dr6t/ZUai3EAq7M=",
                    UserName = "EltonGarbin",
                    CPF = "89599549422",
                    IsAdmin = true
                }
            );
            #endregion

            #region ScrumMaster
            context.AllStatus.AddOrUpdate(x => x.Id,
                new Status() { Id = 1, Classificacao = Classificacao.Available, Descricao = "DisponÝvel" },
                new Status() { Id = 2, Classificacao = Classificacao.Ready, Descricao = "└ fazer" },
                new Status() { Id = 3, Classificacao = Classificacao.InProgress, Descricao = "Fazendo" },
                new Status() { Id = 4, Classificacao = Classificacao.Done, Descricao = "Feito" }
            );

            context.Times.AddOrUpdate(x => x.Id,
                new Time() { Id = 1, Nome = "Time de Desenvolvimento" }
            );
            #endregion
        }
    }
}
