using SeguridadWeb.EntidadesDeNegocio;
using SeguridadWeb.LogicaDeNegocio;
using SeguridadWeb.MinimalAPI.DTOs;

namespace SeguridadWeb.MinimalAPI.EndPoints
{
    public static class RolEndPoint
    {
        public static void AddRolEndPoints(this WebApplication app)
        {
           // app.MapPost("/rol/create", rolBL.CrearAsync);
            app.MapPost("/rol/create", async (RolCreate pRol, RolBL rol2BL) =>{
                return await rol2BL.CrearAsync(new Rol
                {
                    Nombre = pRol.Nombre,
                });
            });
            RolBL rolBL = new RolBL();
            app.MapPost("/rol/delete", rolBL.EliminarAsync);
            app.MapPut("/rol", rolBL.ModificarAsync);
            app.MapGet("/rol", rolBL.ObtenerTodosAsync);
            app.MapPost("/rol/search", rolBL.BuscarAsync);
        }
        
    }
}
