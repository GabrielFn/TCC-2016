﻿using System.Web.Mvc;

namespace StartIdea.UI.Areas.TeamMember
{
    public class TeamMemberAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TeamMember";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TeamMember_default",
                "TeamMember/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "StartIdea.UI.Areas.TeamMember.Controllers" }
            );
        }
    }
}