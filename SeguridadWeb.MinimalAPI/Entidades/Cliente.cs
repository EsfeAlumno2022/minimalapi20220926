namespace SeguridadWeb.MinimalAPI.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void ejecutarxCosa(Action<int> pFunc,int pNum)
        {
            pFunc(pNum);
        }
    }
}
