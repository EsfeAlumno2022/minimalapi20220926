using SeguridadWeb.LogicaDeNegocio;

namespace SeguridadWeb.MinimalAPI.EndPoints
{
    public static class ConfigEndPoints
    {
        public static void AddEndPoints(this WebApplication app)
        {
           app.AddRolEndPoints();
            app.AddUsuarioEndPoints();
        }
    }
}
