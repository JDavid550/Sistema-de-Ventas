using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema_de_Ventas.Areas.User.Models;

namespace Sistema_de_Ventas.Areas.User.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public InputModel Input { get; set; } //A esto accede desde el atributo asp-for en la etiqueta input correspondiente
        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; } //IFormFile es una clase incluida en el framework para trabajar con http
        }
    }
}
