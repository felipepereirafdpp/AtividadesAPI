namespace AtividadesAPI.Barbearia
{
    public class BarbeirosModel
    {
        public BarbeirosModel(int id, string nome, string imagemBarbeio, string descricao)
        {
            Id = id;
            Nome = nome;
            ImagemBarbeio = imagemBarbeio;
            Descricao = descricao;
        }

        public int Id { get;}
        public string Nome { get;}
        public  string ImagemBarbeio { get;}
        public string Descricao { get;}


    }
}