using System;
using System.Linq;
using MyBank.App.Views.Login;
using MyBank.Domains.Entities;
using MyBank.Domains.Services;
using MyBank.Infrastructure.Context;
using MyBank.Infrastructure.Repositories;

namespace MyBank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForms());


        }

    }
}