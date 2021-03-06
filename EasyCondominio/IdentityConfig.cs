﻿using DAL.Contexto;
using EasyCondominio.Infraestrutura;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyCondominio
{
  public class IdentityConfig
  {
    public void Configuration(IAppBuilder app)
    {
      app.CreatePerOwinContext(IdentityContext.Create);
      app.CreatePerOwinContext<GerenciadorUsuario>(GerenciadorUsuario.Create);
      app.CreatePerOwinContext<GerenciadorPapel>(GerenciadorPapel.Create);
      app.UseCookieAuthentication(new CookieAuthenticationOptions
      {
        AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        LoginPath = new PathString("/Account/Login"),
      });
    }
  }
}