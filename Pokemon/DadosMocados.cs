namespace AtividadesAPI.Pokemon
{
    public static class DadosMocados
    {
        public static IList<PokemonModel> RetornarPokemon() 
        {
            List<PokemonModel> lista = new List<PokemonModel>();
            PokemonModel bulbasau = new PokemonModel(1, "Bulbasau", "Grama", "Veneno", " "); 
            PokemonModel Charmander = new PokemonModel(4, "Charmander", "Fogo", null, "");
            PokemonModel Skair = new PokemonModel(7, "Squirtle", "Água", null, "");

            lista.Add(bulbasau);
            lista.Add(Charmander);
            lista.Add(Skair);

            return lista;
        }
    }
}
