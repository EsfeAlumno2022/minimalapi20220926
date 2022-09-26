// agregar la siguiente libreria
using SeguridadWeb.EntidadesDeNegocio;
namespace SeguridadWeb.WebAPI.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(Usuario pUsuario);
    }
}
