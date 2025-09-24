using Projeto_Inicial.Classes;

namespace Projeto_Inicial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Você criou uma instância de classe/objeto
            //a instância do objeto, é literalmente um item/conceito criado com base no meu objeto
            Garrafa garrafa1 = new Garrafa("goscase", 500, "metal", "preto", false);

            string resultado = garrafa1.abrirGarrafa();
            garrafa1.mostrarGarrafa();
            Console.WriteLine(resultado);

            Pokemon pokemon1 = new Pokemon(95, "Onix", "Pedra/Terra", 210.0, 8.8, "Robustez, Cintura Férrea", "Onix é um Pokémon serpente de pedra, com corpo segmentado que se estende por longas distâncias. Muito resistente e forte em batalhas físicas.");
            pokemon1.pokeScanner();
            Pokemon pokemon2 = new Pokemon(25, "Pikachu", "Elétrico", 6.0, 0.4, "Eletricidade Estática, Para-Raio", "Pikachu é um Pokémon roedor elétrico, conhecido por armazenar eletricidade nas bochechas. Popular mascote da franquia Pokémon.");
            pokemon2.pokeScanner();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
