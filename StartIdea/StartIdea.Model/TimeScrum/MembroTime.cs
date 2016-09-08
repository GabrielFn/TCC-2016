﻿using StartIdea.Model.ScrumArtefatos;
using System.Collections.Generic;

namespace StartIdea.Model.TimeScrum
{
    public class MembroTime
    {
        public MembroTime()
        {
            HistoricoEstimativas = new HashSet<HistoricoEstimativa>();
            Tarefas = new HashSet<Tarefa>();
            StatusTarefas = new HashSet<StatusTarefa>();
        }

        public int Id { get; set; }
        public string Funcao { get; set; }
        public int TimeId { get; set; }
        public int UsuarioId { get; set; }

        public virtual Time Time { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<HistoricoEstimativa> HistoricoEstimativas { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
        public virtual ICollection<StatusTarefa> StatusTarefas { get; set; }
    }
}
