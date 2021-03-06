﻿using StartIdea.Model.TimeScrum;
using System;

namespace StartIdea.Model.ScrumArtefatos
{
    public class StatusTarefa
    {
        public StatusTarefa()
        {
            DataInclusao = DateTime.Now;
        }

        #region Fields
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public int TarefaId { get; set; }
        public int StatusId { get; set; }
        public int MembroTimeId { get; set; }
        #endregion

        #region References
        public virtual Tarefa Tarefa { get; set; }
        public virtual Status Status { get; set; }
        public virtual MembroTime MembroTime { get; set; }
        #endregion
    }
}