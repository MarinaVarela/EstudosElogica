using System.Diagnostics.Metrics;
using System.Globalization;

namespace ExercicioCsharp
{
    public abstract class Shape
    {
        public string Description { get; set; }
        public abstract void SaveToFile(string fileName);
        public void ReadFile(string fileName)
        {
            var conteudo = File.ReadAllText(fileName);
            Console.WriteLine(conteudo);
        }
    }

    public class Circle : Shape
    {
        public override void SaveToFile(string fileName)
        {
            // Criando o arquivo Shapes
            var arquivo = new StreamWriter(fileName, true);

            // Incluindo o Raio
            Console.Write("Informe o raio do cículo desejado: ");
            var raioInformado = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (raioInformado > 0)
            {
                // Incluindo a descrição
                Description = "Círculo, figura geométrica plana";
                arquivo.WriteLine("Raio: " + raioInformado + "\n" + Description);
            }
            else
            {
                var e = new ArithmeticException();
                Console.WriteLine("O raio informado é inválido: " + e);
            }
            arquivo.Close();
        }
    }
}




