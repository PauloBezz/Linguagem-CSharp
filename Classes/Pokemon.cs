namespace Projeto_Inicial.Classes
{
    public class Pokemon
    {
        // Atributos
        int id;
        string nome = string.Empty;
        string tipo = string.Empty;
        double peso = 0f;
        double altura = 0f;
        string habilidades = string.Empty;
        string descricao = string.Empty;

        // Construtor
        public Pokemon(int id, string nome, string tipo, double peso, double altura, string habilidades, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.peso = peso;
            this.altura = altura;
            this.habilidades = habilidades;
            this.descricao = descricao;
        }

        // Métodos
        public void pokeScanner()
        {
            Console.WriteLine($"Nº{id} {nome} é do tipo {tipo}, pesa {peso}kg e pode medir {altura}m. Habilidades: {habilidades} Descrição: {descricao}");
        }
    }
}