﻿using System.Collections.Generic;  namespace StartIdea.Model.ScrumArtefatos {     public enum Classificacao     {         Ready = 1,         InProgress = 2,         Done = 3     }      public class Status     {         public Status()         {             StatusTarefas = new HashSet<StatusTarefa>();         }          public int Id { get; set; }         public string Descricao { get; set; }         public Classificacao Classificacao { get; set; }          public virtual ICollection<StatusTarefa> StatusTarefas { get; set; }     } }