using Microsoft.AspNetCore.Identity;

namespace TC.Identidade.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ocorreu um erro desconhecido" }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(DefaultError), Description = "Senha incorreta" }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(DefaultError), Description = "Token inválido" }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(DefaultError), Description = "Já existe um usuário com este login" }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(DefaultError), Description = $"O email '{email}' é inválido" }; }
    }
}
