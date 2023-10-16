using System.ComponentModel.DataAnnotations;

namespace ExercicioASPNET.Models
{
    public class Estudante
    {
        [Key] 
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Nome do Estudante:")]
        public required string Name { get; set; } 

        [Range(0, 140, ErrorMessage = "Algo está errado. Confirme o informado e insira uma idade válida." )] // validação de 0 a 140 da idade
        public int Age { get; set; }

        [EmailAddress (ErrorMessage = "Algo está errado. Confirme o informado e insira um e-mail válido.") ]
        public required string Email { get; set; }

        [Compare("Email", ErrorMessage = "E-mails informados não são iguais.")]
        public required string EmailCheck { get; set; }

        public bool Active { get; set; }
    }
}

// DUVIDAS: 
// Colocar public required ou annotation Required?

// Referências:
// https://learn.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
// https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/validation-with-the-data-annotation-validators-cs
// https://stackoverflow.com/questions/41536603/visual-studio-code-entity-framework-core-add-migration-not-recognized
// https://stackoverflow.com/questions/33148698/how-can-i-install-and-use-entity-framework-core-in-visual-studio-code
// https://learn.microsoft.com/en-us/archive/msdn-magazine/2016/august/asp-net-core-write-apps-with-visual-studio-code-and-entity-framework
// CRUD https://www.youtube.com/watch?v=zr3QiQDZ0-k
// https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/implementing-basic-crud-functionality-with-the-entity-framework-in-asp-net-mvc-application