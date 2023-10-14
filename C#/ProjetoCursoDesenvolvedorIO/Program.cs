
namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*AulaClasses();
             AulaPropriedadeSomenteLeitura();
             AulaHeranca();
             AulaClasseSelada();
             AulaClasseAbstrata();
             AulaRecord();
             AulaInterface();
             Conversores();
             TrabalhandoComString();
             TrabalhandoComData();
             TratandoExcecoes();
            TrabalhandoComArq();*/
            // TrabalhandoComLinq();
        }

        // private static void TrabalhandoComLinq()
        // {
        //     var linq = new Linq.TrabalhandoComLinq();
        //     linq.AulaWhere();
        //     linq.AulaOrdenação();
        //     linq.AulaTake();
        //     linq.AulaCount();
        //     linq.AulaFirstEFirstOrDefault();
        // }

        /*
        private static void TrabalhandoComArq()
        {
            var arq = new Arquivos.TrabalhandoComArq();
            arq.CriandoArq();
            arq.LendoArq();
            arq.ExcluindoArq();
        }

        private static void TratandoExcecoes()
        {
            var excecao = new Erros.TratandoExcecoes();
            excecao.GerandoException();
            excecao.TratandoException();
        }

        private static void TrabalhandoComData()
        {
            var data = new Data.TrabalhandoComData();
            data.ClassDateTime();
            data.Subtraindo();
            data.AddDiaMesAno();
            data.AddHorasMinSeg();
            data.AddDiaSemana();
            data.AddDateOnly();
            data.AddTimeOnly();
        }

        private static void TrabalhandoComString()
        {
            var strings = new Strings.TrabalhandoComString();
            strings.ConverterMinusculo();
            strings.ConverterMaiusculo();
            strings.Substring();
            strings.Range();
            strings.Contains();
            strings.Trim();
            strings.StartEndsWith();
            strings.Replace();
            strings.Length();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            conversores.ConvertAndParse();
            conversores.TryParse();
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            var notificacaoFuncionario = new Cadastro.NotificacaoFuncionario();
            notificacaoFuncionario.Notificar();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void AulaRecord() // eficiência na comparação do valor das instâncias
        {
            var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

            Console.WriteLine(curso1 == curso2);
            Console.WriteLine(curso1.Equals(curso2));

            var curso3 = new Cadastro.Curso(1, "Curso"); // exemplo nova semântica 
            var curso4 = curso3 with { Descricao = "Teste Novo" };

            var curso5 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" }; // outra semantica
            var curso6 = new Cadastro.CursoTeste
            {
                Id = curso5.Id,
                Descricao = "Nova descrição"
            };

            Console.WriteLine(curso5.Descricao);
            Console.WriteLine(curso6.Descricao);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Dog";
            cachorro.ImprimirAnimal();
        }

        private static void AulaClasseSelada()
        {
            var config = new Cadastro.Config
            {
                Host = "localhost"
            };

            Console.WriteLine(config.Host);
        }

        private static void AulaHeranca() // metodo
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1; // acesso das propriedades da classe pai msm sem colocar na classe pessoa fisica 
            pessoaFisica.Nome = "Nome teste";
            pessoaFisica.Endereco = "Endereço teste";
            pessoaFisica.Cidade = "Cidade teste";
            pessoaFisica.Cep = "123456789";
            pessoaFisica.CPF = "0987654321";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCPF();

            var funcionario = new Cadastro.Funcionario
            {
                Id = 1, // outra forma de passar  
                Nome = "Nome teste",
                Endereco = "Endereço teste",
                Cidade = "Cidade teste",
                Cep = "123456789",
                CPF = "0987654321"
            };

            funcionario.ImprimirDados();
            funcionario.ImprimirCPF();
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNum(10, 20);  // acessando class e propriedades sem instanciar, ver a public static class Calculos no ClassEOutrosTipos
            Console.WriteLine(resultado);

            //var produto = new Cadastro.Produto(); // a instancia se transforma em objeto, quando não tiver usando mais será descartado nessa classe estática
            //produto.SetID(1);
            //produto.Descricao = "Teclado";

            //produto.ImprimirDescricao();
            //Console.WriteLine(produto.GetID());
        }

        private static void AulaPropriedadeSomenteLeitura() // não retorna nada, só executa
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            Console.WriteLine(produto.Estoque)
        }
        */
    }
}



// // EXERCÍCIO PARA TREINAR AS OPERAÇÕES

// // 1
// Console.WriteLine("Insira dois números");
// var number1 = Console.ReadLine();
// var number2 = Console.ReadLine();

// var igual = number1 == number2;
// Console.WriteLine(number1 + " é  a " + number2 + "? " + igual);

// var diferente = number1 != number2;
// Console.WriteLine(number1 + " é diferente a " + number2 + "? " + diferente);

// var maior = Convert.ToInt32(number1) > Convert.ToInt32(number2);
// Console.WriteLine(number1 + " é maior a " + number2 + "? " + maior);

// var maiorIgual = Convert.ToInt32(number1) >= Convert.ToInt32(number2);
// Console.WriteLine(number1 + " é maior ou igual a " + number2 + "? " + maiorIgual);

// // 2

// Console.WriteLine("Insira dois valores true ou false");
// var valor1 = Console.ReadLine();
// var valor2 = Console.ReadLine();

// var ambosVerdadeiros = Convert.ToBoolean(valor1) && Convert.ToBoolean(valor2);
// Console.WriteLine(valor1 + " e " + valor2 + " são ambos verdadeiros? " + ambosVerdadeiros);

// var peloMenosUmVerdadeiro = Convert.ToBoolean(valor1) || Convert.ToBoolean(valor2);
// Console.WriteLine(valor1 + " e " + valor2 + " contém pelo menos um verdadeiro? " + peloMenosUmVerdadeiro);

// var ambosFalsos = !Convert.ToBoolean(valor1) && !Convert.ToBoolean(valor2);
// Console.WriteLine(valor1 + " e " + valor2 + " são ambos falsos? " + ambosFalsos);

// var primeiroVerdadeiroSegundoFalso = Convert.ToBoolean(valor1) && !Convert.ToBoolean(valor2);
// Console.WriteLine(valor1 + " e " + valor2 + " é primeiro verdadeiro e segundo falso? " + primeiroVerdadeiroSegundoFalso);



// --------------------------------------------------------

// INICIALIZAÇÃO DE PROJETO

// > dotnet new console --use-program-main -n AppCliente //class program e argumento main e -n será para nomear
// > 
// >
// >
// >
