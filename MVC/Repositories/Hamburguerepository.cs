using System.Collections.Generic;

namespace MVC.Repositories
{
    public class Hamburguerepository
    {
        private const string PATH = "Database/Habburguer";

        public Hamburguerepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();

            }
        }

        public List<Hamburguer> ObterTodos()
        {
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linhas in linhas)
            {
                Hamburguer h = new Hamburguerepository();
            }
        }
    }
}