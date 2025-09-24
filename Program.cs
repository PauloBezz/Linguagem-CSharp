using Projeto_Inicial.Classes;

namespace Projeto_Inicial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Voc� criou uma inst�ncia de classe/objeto
            //a inst�ncia do objeto, � literalmente um item/conceito criado com base no meu objeto
            Garrafa garrafa1 = new Garrafa("goscase",500, "metal", "preto", false);

            string resultado = garrafa1.abrirGarrafa();
            garrafa1.mostrarGarrafa();
            Console.WriteLine(resultado);




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
