namespace MVC.Repositories
{
    public class Hamburguerepository
    {
        private const string PATH = "Database/Habburguer";

        public HamburguerRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();

            }
        }

        public List<Hamburguer> ObterTodos()
        {

        }
    }
}