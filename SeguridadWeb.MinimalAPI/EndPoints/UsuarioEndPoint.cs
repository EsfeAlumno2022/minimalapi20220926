using SeguridadWeb.LogicaDeNegocio;

namespace SeguridadWeb.MinimalAPI.EndPoints
{
    public static class UsuarioEndPoint
    {
        public static void AddUsuarioEndPoints(this WebApplication app)
        {
            UsuarioBL usuarioBL = new UsuarioBL();
            app.MapPost("/usuario/create", usuarioBL.CrearAsync);
            app.MapPost("/usuario/delete", usuarioBL.EliminarAsync);
            app.MapPut("/usuario", usuarioBL.ModificarAsync);
            app.MapGet("/usuario", usuarioBL.ObtenerTodosAsync);
            app.MapPost("/usuario/search", usuarioBL.BuscarAsync);
        }
    }
}
