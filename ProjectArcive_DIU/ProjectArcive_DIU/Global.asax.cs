using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Models;
using AutoMapper;

namespace ProjectArcive_DIU
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserViewModel, User>();
                cfg.CreateMap<User, UserViewModel>();

                cfg.CreateMap<ProjectViewModel, Project>();
                cfg.CreateMap<Project, ProjectViewModel>();
            });
        }
    }
}
