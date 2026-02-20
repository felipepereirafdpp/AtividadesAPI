using AtividadesAPI.CRUD.Modell;
using Microsoft.EntityFrameworkCore;

namespace AtividadesAPI.CRUD.Context

{
    public class AgendaContext : DbContext //Criando a classe de contexto para o banco de dados que herda a DbContexte os poderes de criar tabelas , salvar Dados , Atualizar, Deletar
    {
        //Criando o construtor da classe de contexto que recebe as opções de configuração do banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        // DbSet<ContatoModel> esta criando uma tabela chamada Contatos no Banco com referencia ao modelo ContatoModel
        public DbSet<ContatoModel> Contatos { get; set;} 
    }
}
