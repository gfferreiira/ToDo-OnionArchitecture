using System.ComponentModel.DataAnnotations;
using Todo.Domain.Validation;

namespace Todo.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        private void ValidadeDomain(int id, string name, string email, string password,
           string description, DateTime createdAt)
        {
            DomainExcepetionValidation.When(password == null, "Senha não pode estar vazia");
        }
    }
}
