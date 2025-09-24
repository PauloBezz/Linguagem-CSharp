using System.Runtime.InteropServices;

namespace Projeto_Inicial.Classes
{
    public class Garrafa
    {
        // o objeto é a estrutura de determinado item/conceito (ex: cliente)
        // objeto: a base
        // instância: literalmente o objeto pronto, com dados/valores

        //atributos = características
        string marca = string.Empty;
        int volume = 0 ;
        string material = string.Empty;
        string cor = string.Empty;
        bool temCanudo = false;

        //construtor do objeto
        public Garrafa(string marca, int volume,string material, string cor, bool temCanudo){ 
            this.marca = marca;
            this.volume = volume;
            this.material = material;
            this.cor = cor;
            this.temCanudo = temCanudo;
        }

        //métodos - funções
        public string abrirGarrafa()
        {
            return "você abriu a garrafa";
        }

        public void mostrarGarrafa()
        {
            Console.WriteLine($"Marca:{marca}, Volume: {volume}, Material{material}, Cor {cor}, Tem Canudo? {temCanudo}");
        }
    }
}