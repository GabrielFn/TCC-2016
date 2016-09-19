﻿using PagedList;
using StartIdea.Model.ScrumArtefatos;

namespace StartIdea.UI.Areas.ProductOwner.ViewModels
{
    public class ProductBacklogVM : ProductBacklog
    {
        public IPagedList<ProductBacklog> ProductBacklogList { get; set; }
        public ProductBacklog ProductBacklogEdit { get; set; }
        public ProductBacklog ProductBacklogCreate { get; set; }
        public string DisplayEdit { get; set; }
    }
}