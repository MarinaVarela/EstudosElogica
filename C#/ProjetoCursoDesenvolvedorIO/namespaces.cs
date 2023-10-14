using System.Diagnostics.Metrics;

// namespace Cadastro
// {
//     public static class Calculos
//     {
//        public static int SomarNum(int a, int b) // os metodos não serão necessários instanciar
//        {
//            return a + b;
//        }
//     }

//     public class Produto // classe
//     {
//        private int Id;

//        public string Descricao { get; set; } // atributos e metodos

//        //public readonly int Estoque // somente leitura outra forma 
//        public int Estoque { get;} // é só leitura por isso só get

//        public Produto() 
//        {
//            Estoque = 1; 
//        }

//        public void ImprimirDescricao() // apenas executa não retorna nenhum valor
//        {
//            Console.WriteLine(GetID() + " - " + Descricao);
//        }

//        public void SetID(int id)
//        {
//            Id = id;
//        }

//        public int GetID()
//        {
//            return Id;
//        }
//     }

//     public class Pessoa
//     {
//         public int Id { get; set; }
//         public string Nome { get; set; }
//         public string Endereco { get; set; }
//         public string Cidade { get; set; }
//         public string Cep { get; set; }


//         public void ImprimirDados()  // metodo para herança
//         {
//             Console.WriteLine(Id + " - " + Nome);
//             Console.WriteLine("Endereço: " + Endereco);
//             Console.WriteLine("Cidade: " + Cidade);
//             Console.WriteLine("CEP: " + Cep);
//         }
//     }

//     public class PessoaFisica : Pessoa // herança da classe pessoa
//     {
//         public string CPF { get; set; }

//         public void ImprimirCPF()
//         {
//             Console.WriteLine("CPF: " + CPF);
//         }

//     }

//     public class Funcionario : PessoaFisica
//     {
//         public string Matricula { get; set; }
//     }

//     public sealed class Config // não tem como herdar por ser selada
//     {
//         public string Host { get; set; }
//     }

//     public abstract class Animal // classes abstratas, são super classes, irão armazenar atributos e métodos comuns às classes que a irão herdar, permitindo um maior reaproveitamento de código
//     {
//         public string Nome { get; set; }
//         public abstract string GetInformacoes(); // metodo abstrato que força uma implementação por uma nova classe para complementar

//         public void ImprimirAnimal()
//         {
//             Console.WriteLine("Nome Animal: " + Nome);
//             Console.WriteLine("Info: " + GetInformacoes());
//         }
//     }

//     public class Cachorro : Animal
//     {
//         public override string GetInformacoes() // complementa o metodo get
//         {
//             return "Cachorro é um bom amigo";
//         }

//     }

//     public record Curso // novo tipo de classe ajuda na produtividade no desenvolvimento pq não precisa escrever o override. compara valores
//     {
//         public int Id { get; set; }
//         public string Descricao { get; set; }
//         public override bool Equals(object? obj)
//         {
//             if (obj == null || GetType() != obj.GetType())
//             {
//                 return false;
//             }
//             else if (obj is Curso curso)
//             {
//                 return Id == curso.Id && Descricao == curso.Descricao;
//             }

//             return base.Equals(obj);
//         }

//         public static bool operator == (Curso a, Curso b)
//         {
//             return a.Equals(b);
//         }
//         public static bool operator != (Curso a, Curso b)
//         {
//             return !a.Equals(b);
//         }
//     }

//     public record Curso(int Id, string Descricao); // outra semantica de record. uma propriedade, são instanciados na criação do objeto

//     public class CursoTeste
//     {
//         public int Id {get; set;}
//         public string Descricao {get; set;}
//     }

//     public interface INotificacao  // definir as operaçõs que o objeto é obrigado a implementar. An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface.
//     {
//         string Descricao { get; set; }
//         void Notificar(); // assinatura da interface
//     }

//     public class NotificacaoCliente : INotificacao
//     {
//         public string Descricao { get; set; }

//         public void Notificar()
//         {
//             Console.WriteLine("Notificando cliente");
//         }
//         public void NotificarOutros()
//         {
//             Console.WriteLine("Notificando outros");
//         }
//     }

//     public class NotificacaoFuncionario : INotificacao
//     {
//         public string Descricao { get; set; }

//         public void Notificar()
//         {
//             Console.WriteLine("Notificando Funcionário");
//         }

//         public void NotificarOutros()
//         {
//             Console.WriteLine("Notificando Funcionário");
//         }
//     }
// }

// namespace Conversores
// {
//     public class Conversor
//     {
//         public void ConvertAndParse()
//         {
//             int num = int.Parse("1");
//             int numero = Convert.ToInt32("1");
//             Console.WriteLine(num);
//         }

//         public void TryParse()
//         {
//             var numero = ("123434234");
//             if (int.TryParse(numero, out int numeroConvertido))
//             {
//                 Console.WriteLine("numero convertido com sucesso");
//             }
//             Console.WriteLine(numeroConvertido);

//         }

//     }
// }

// namespace Strings
// {
//     public class TrabalhandoComString
//     {
//         public void ConverterMinusculo()
//         {
//             Console.Write("Digite algo: ");
//             var linha = Console.ReadLine();
//             Console.WriteLine(linha.ToLower());
//         }

//         public void ConverterMaiusculo()
//         {
//             Console.Write("Digite algo: ");
//             var linha = Console.ReadLine();
//             Console.WriteLine(linha.ToUpper());
//         }

//         public void Substring()
//         {
//             Console.Write("Digite algo: ");
//             var linha = Console.ReadLine();
//             Console.WriteLine(linha.Substring(0, 6)); // se passar apenas (6), começa da sexta posição
//         }

//         public void Range()
//         {
//             string nomeArquivo = "2023_01_01_backup.bak";

//             string ano = nomeArquivo[..4];
//             Console.WriteLine(ano);

//             string extensao = nomeArquivo[^3..]; // o tipo de extensao do arquivo, neste caso BAK
//             Console.WriteLine(extensao);

//             string nomeBackup = nomeArquivo[11..^4];
//             Console.WriteLine(nomeBackup);

//             string nomeSemExtensao = nomeArquivo[..^4];
//             Console.WriteLine(nomeSemExtensao);
//         }

//         public void Contains()
//         {
//             string nomeContains = "2023_01_01_backup.bak";

//             if (nomeContains.Contains("backup"))
//             {
//                 Console.WriteLine("Palavra encontrada");
//             }
//             else
//             {
//                 Console.WriteLine("Palavra não encontrada");
//             }

//         }

//         public void Trim()
//         {
//             string nomeTrim = "**RAFAEL ALMEIDA**";
//             Console.WriteLine("estou trimando TOTAL: " + nomeTrim.Trim('*'));
//             Console.WriteLine("estou trimando apenas INICIO: " + nomeTrim.TrimStart('*'));
//             Console.WriteLine("estou trimando apenas FINAL: " + nomeTrim.TrimEnd('*'));
//         }

//         public void StartEndsWith()
//         {
//             string nomeStartEnds = "Curso Csharp";
//             Console.WriteLine("INICIO: " + nomeStartEnds.StartsWith("Curso"));
//             Console.WriteLine("FINAL: " + nomeStartEnds.EndsWith("Csharp0"));
//         }

//         public void Replace()
//         {
//             string nomeReplace = "Curso Csharp";
//             Console.WriteLine(nomeReplace);
//             Console.WriteLine(nomeReplace.Replace("Csharp", "C#"));
//         }

//         public void Length()
//         {
//             string textoLength = Console.ReadLine();
//             Console.WriteLine(textoLength.Length);
//         }

//     }
// }

// namespace Data
// {
//     public class TrabalhandoComData
//     {
//         public void ClassDateTime()
//         {
//             var dateDateTime = new DateTime(2012, 12, 01, 19, 22, 23);
//             var dateDateTimeParse = DateTime.Parse("2012/12/01 19:22:23");
//             var dateNow = DateTime.Now;
//             var dateToday = DateTime.Today;

//             Console.WriteLine(dateDateTime);
//             Console.WriteLine(dateDateTimeParse);
//             Console.WriteLine(dateNow);
//             Console.WriteLine(dateToday);

//             Console.WriteLine(dateToday.ToString("dd-MM-yyyy"));

//             var dateOffset = new DateTimeOffset(dateNow, new TimeSpan(-3, 0, 0));
//             Console.WriteLine(dateOffset.LocalDateTime);
//             Console.WriteLine(dateOffset.UtcDateTime);
//         }

//         public void Subtraindo()
//         {
//             var dateDateTimeParse = DateTime.Parse("2012-12-01");
//             var dateNow = DateTime.Now;

//             // var diff = dateNow - dateDateTimeParse; // outra forma 
//             var diff = dateNow.Subtract(dateDateTimeParse);
//             Console.WriteLine((int)diff.TotalDays); // (int) para puxar apenas a parte inteira. força mudança do double para int
//             Console.WriteLine((int)diff.TotalHours);
//         }

//         public void AddDiaMesAno()
//         {
//             var dateDMA = DateTime.Now;
//             Console.WriteLine(dateDMA.AddDays(3).ToString("dd-MM-yyyy"));
//             Console.WriteLine(dateDMA.AddMonths(1));
//             Console.WriteLine(dateDMA.AddYears(2));
//         }

//         public void AddDiaSemana()
//         {
//             var dateDS = DateTime.Now;
//             Console.WriteLine(dateDS.DayOfWeek);
//         }

//         public void AddDateOnly()
//         {
//             var somenteData = DateOnly.Parse("2022-02-01");
//             Console.WriteLine(somenteData);
//             Console.WriteLine(somenteData.ToString("dd-MM-yyyy"));
//         }

//         public void AddTimeOnly()
//         {
//             var somenteHora = TimeOnly.Parse("12:40:30");
//             Console.WriteLine(somenteHora);
//             Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
//         }

//     }
// }

// namespace Erros
// {
//     public class TratandoExcecoes
//     {
//         public void GerandoException()
//         {
//             while (true)
//             {
//                 Console.Write("informe um número: ");
//                 var number = Console.ReadLine();
//                 var result = 500 / int.Parse(number);
//                 Console.WriteLine(result);
//             }

//         }

//         public void TratandoException()
//         {
//             while (true)
//             {
//                 try
//                 {
//                     Console.Write("informe um número: ");
//                     var number = Console.ReadLine();
//                     var result = 500 / int.Parse(number);
//                     Console.WriteLine(result);
//                 }
//                 catch (Exception e)
//                 {
//                     Console.WriteLine("Ocorreu um erro: " + e.Message + e.StackTrace);
//                 }
//             }
//         }
//     }
// }

//namespace Arquivos
//{
//    public class TrabalhandoComArq
//    {
//        public void CriandoArq()
//        {
//            var escrever = new StreamWriter("Cadastro.txt", true);
//            Console.Write("Informe um nome: ");
//            var nomeArq = Console.ReadLine();
//            escrever.WriteLine("Id: " + Random.Shared.Next(1, 100));
//            escrever.WriteLine("Nome: " + nomeArq);
//            escrever.WriteLine("-------------------------------");
//            escrever.Close();
//        }

//        public void LendoArq()
//        {
//            var conteudo = File.ReadAllText("Cadastro.txt");
//            Console.WriteLine(conteudo);

//            var ler = new StreamReader("Cadastro.txt"); // var ler linha por linha 
//            while (!ler.EndOfStream)
//            {
//                var linha = ler.ReadLine();
//                Console.WriteLine(linha);
//            }
//            ler.Close();
//        }

//        public void ExcluindoArq()
//        {
//            if (File.Exists("Cadastro.txt"))
//            {
//                File.Delete("Cadastro.txt"); // nome ou diretório
//                Console.WriteLine("Exclusão concluída com sucesso!");
//            }
//        }
//    }
//}

// namespace Linq
// {
//     class TrabalhandoComLinq
//     {
//         public void AulaWhere()
//         {
//             string nomeCompleto = "Rafael Almeida";

//             Func<char, bool> filtro = c => c == 'a';
//             //var resultado = nomeCompleto.Where(filtro);
//             //var resultado = nomeCompleto.Where(p => p == 'A');

//             var resultado2 = from c in nomeCompleto where c == 'e' select c;

//             foreach (var letra in resultado2)
//             {
//                Console.WriteLine(letra);
//             }

//             var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
//             var resultado = numeros.Where(p => p >= 10);

//             foreach (var numero in resultado)
//             {
//                Console.WriteLine(numero);
//             }
//         }

//         public void AulaOrdenação()
//         {
//             var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
//             var nomer = new string[] { "Rafael", "Eduardo", "Bruno" };

//             //var resultado = numeros.OrderBy(p => p);
//             //var resultado = numeros.OrderByDescending(p => p);
//             var resultado = nomer.OrderBy(p => p);


//             foreach (var numero in resultado)
//             {
//                 Console.WriteLine(numero);
//             }
//         }

//         public void AulaTake()
//         {
//             var numeroTake = new int[] { 10, 6, 5, 50, 15, 2 };

//             // var resultadoTake = numeroTake.Take(3);
//             var resultadoTake = numeroTake.Where(p => p > 10).Take(3).OrderBy(p => p);

//             foreach (var numero in resultadoTake)
//             {
//                 Console.WriteLine(numero);
//             }
//         }

//         public void AulaCount()
//         {
//             var numeroCount = new int[] { 10, 6, 5, 50, 15, 2 };

//             // var resultadoTake = numeroTake.Take(3);
//             var resultadoCount = numeroCount.Count(p => p > 10);
//             Console.WriteLine(resultadoCount);
//         }

//         public void AulaFirstEFirstOrDefault()
//         {
//             var numeroFirst = new int[] { 10, 6, 5, 50, 15, 2 };
//             // var numeroFirst = new int[] { }; // vazio devolve uma exception

//             // var resultadoFirst = numeroFirst.First();
//             // var resultadoFirst = numeroFirst.First(p => p > 15); // primeiro maior que 15
//             // var resultadoFirst = numeroFirst.FirstOrDefault(); // quando for vazio ou não existir, devolve o valor default. Então 0
//             var resultadoFirst = numeroFirst.FirstOrDefault(p => p > 100, -99); // neste caso -99 será o default pre definido por a gente

//             Console.WriteLine(resultadoFirst);
//         }
//     }
// }