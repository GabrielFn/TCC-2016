﻿using PagedList;
using StartIdea.Model.ScrumArtefatos;

namespace StartIdea.UI.ViewModels
{
    public class ProductBacklogVM
    {
        public IPagedList<ProductBacklog> BackLogItem { get; set; }
        public StoryPoint? tamanhos { get; set; }

        public string Descricao { get; set; }
        public int? sprintId { get; set; }
    }
}