// using System.Collections;

// Console.WriteLine("Opa, meu parceiro");

// // VARIÁVEIS

// int idade = 33; // tipo nome = valor
// Console.WriteLine(idade);

// string nomePessoa = "Rafael"; // STRING apenas aspas duplas
// Console.WriteLine(nomePessoa);

// decimal valor = 200.99m;
// double valorDouble = 200.99;
// float valorFloat = 200.99f;
// Console.WriteLine(valor);
// Console.WriteLine(valorDouble);
// Console.WriteLine(valorFloat);

// var idadeNova = 34; //atribuida ao tipo int automaticamente
// Console.WriteLine(idadeNova);

// char flag = 'Y'; // CHAR apenas aspas simples
// Console.WriteLine(flag);

// bool ativo = true;
// Console.WriteLine(ativo);


// // CONSTANTE 
// const string curso = "Curso C#"; // constante tipo nome = valor
// Console.WriteLine(curso);


// // OP ARITMÉTRICOS

// int num1 = 10;
// var num2 = 2;
// var soma = num1 + num2;
// Console.WriteLine(soma);

// int subtracao = num2 - num1;
// Console.WriteLine(subtracao);

// int multiplicacao = num2 * num1;
// Console.WriteLine(multiplicacao);

// int multiplicacao2 = (num2 * num1) * 10;
// Console.WriteLine(multiplicacao2);

// int divisao = num1 / num2;
// Console.WriteLine(divisao);


// // OP RELACIONAIS (== IGUALDADE, > MAIOR, < MENOR, <= MENOR IGUAL, >= MAIOR IGUAL, != DIFERENTE)

// bool igualComparacao = num1 == num2;
// Console.WriteLine(igualComparacao);

// bool maiorIgualComparacao = num1 >= num2;
// Console.WriteLine(maiorIgualComparacao);

// bool menorIgualComparacao = num1 <= num2;
// Console.WriteLine(menorIgualComparacao);

// bool maiorComparacao = num1 > num2;
// Console.WriteLine(maiorComparacao);

// bool menorComparacao = num1 < num2;
// Console.WriteLine(menorComparacao);

// bool diferenteComparacao = num1 != num2;
// Console.WriteLine(diferenteComparacao);


// // OP LÓGICOS (&& AND, || OR, ! NEGAÇÃO)

// var valido = num2 > num1 && 8 > 7; // tipo bool implicito
// Console.WriteLine(valido);

// var valido2 = num2 > num1 || 8 > 7;
// Console.WriteLine(valido2);

// var valido3 = !(num2 > 10);
// Console.WriteLine(valido3);


// // OP TERNÁRIO

// var idadeAdulto = 20;
// string adulto = idadeAdulto > 17 ? "Sim" : "Não";
// Console.WriteLine(adulto);


// // FUNÇÕES

// string NomeCompleto()
// {
//     string primeiroNome = "Rafael ";
//     string segundooNome = "Almeida";
//     return primeiroNome + segundooNome;
// }

// var nome = NomeCompleto();
// Console.WriteLine(nome);

// int SomaValores()
// {
//     int numero1 = 10;
//     int numero2 = 20;
//     return numero1 + numero2;
// }

// var somaValues = SomaValores();
// Console.WriteLine(somaValues);

// void EscreverNome()
// {
//     var nome = NomeCompleto();
//     Console.WriteLine(nome);
// }
// EscreverNome();

// var soma35 = SomaValoresAB (3,5);
// Console.WriteLine(soma35);

// var nomeRafael33 = NomeIdade ("Rafael", 33);
// Console.WriteLine(nomeRafael33);

// int SomaValoresAB (int a, int b){
//     return a + b;
// }

// string NomeIdade (string nome, int idade){
// return "Meu nome é " + nome + " e tenho " + idade;
// }

// // ESTRUTURA DE DADOS

// var arrayList = new ArrayList();
// arrayList.Add(10); // 0 index
// arrayList.Add("Rafael"); // 1
// arrayList.Add(true); // 2

// arrayList.RemoveAt(1); // remover na posição do index
// arrayList.Clear(); // limpa tudo

// Console.WriteLine(arrayList[1]); // acesso por indice

// foreach (var item in arrayList){ // percorrer uma array lista e acessar cada item 
//     Console.WriteLine(item);
// }

// var arrayTipadoNum = new int [3]{1, 2, 3}; // declaração de array tipado, esse só aceta números, por exemplo

// arrayTipadoNum[2] = 10; // mudando os dados no array tipado 

// foreach (var item in arrayTipadoNum)
// {
//     Console.WriteLine(item);
// }

// var arrayTipadoDois = new int[4]; // sem instanciar
// arrayTipadoDois[0] = 10;
// arrayTipadoDois[1] = 20;
// arrayTipadoDois[2] = 30;
// arrayTipadoDois[3] = 40;

// Array.Resize(ref arrayTipadoDois, 11);
// arrayTipadoDois[10] = 100;

// foreach (var item in arrayTipadoDois)
// {
//     Console.WriteLine(item);
// }

// var arrayTipadoString = new string [2];
// arrayTipadoString[0] = "Rafael";
// arrayTipadoString[1] = "Almeida";
// foreach (var item in arrayTipadoString)
// {
//     Console.WriteLine(item);
// }

// // LISTA (list<T>)

// var lista = new List<string>(0)
// {
//     "Rafael",
//     "Almeida",
//     "Professor",
//     "Curso",
//     "DesenvolvedorIO"
// };

// var sobrenomeLista = lista[1]; // acessando valor por indice, retorna ALMEIDA
// Console.WriteLine(sobrenomeLista);

// lista.RemoveAt(3); // removendo pela posição

// foreach (var item in lista)
// {
//     Console.WriteLine(item);
// }

// // DICIONARIO

// var dic = new Dictionary<int, string>() // int é uma chave neste caso. Dictionary<TKey,TValue> Dic
// {
//     { 1, "Rafael"},
//     {2, "Almeida"}
// };

// dic.Add(10, "professor");
// dic[50] = "curso"; // outra forma de adicionar mais valores

// foreach (var item in dic)
// {
//     Console.WriteLine(item.Key);
//     Console.WriteLine(item.Value);
//     Console.WriteLine(item); // apenas item fica uma lista [1, Rafael], por exemplo
// }

// var nomeDic = dic[50];
// Console.WriteLine(nomeDic);

// // QUEUE - First In, First Out

// var queue = new Queue<string>();  // var queue = new Queue(); caso não queira deixar o tipo
// queue.Enqueue("Rafael"); // enqueue empilha o valor
// queue.Enqueue("Almeida");

// var nomeDequeue = queue.Dequeue(); // primeira execução e retira
// Console.WriteLine(nomeDequeue);
// var nomeDequeue2 = queue.Dequeue(); // segunda execução e retira
// Console.WriteLine(nomeDequeue2);

// var nomeQueue = queue.Peek(); // retorna o objeto ao início da Queue<T> sem removê-lo
// Console.WriteLine(nomeQueue);

// foreach (var item in queue)
// {
//     Console.WriteLine(item);
// }

// // STACK - A ordenação é diferente da queue LAST IN, FIRST OUT

// var stack = new Stack<string>();
// stack.Push("Rafael");
// stack.Push("Almeida");

// var nomeStack = stack.Pop(); // acessando e removendo
// Console.WriteLine(nomeStack);

// foreach (var item in stack)
// {
//     Console.WriteLine(item); // retorna ALMEIDA, RAFAEL: last in, first out
// }

// // ESTRUTURA DE CONTROLE 

// // IF ELSE
// var diaDaSemana = 0;
// var diaDeTrabalho = false;

// if (diaDaSemana == 0 && !diaDeTrabalho)
// {
//     Console.WriteLine("Domingo");
// }
// else if(diaDaSemana == 0 && diaDeTrabalho)
// {
//     Console.WriteLine("Domingo e dia de trabalho");
// }
// else
// {
//     Console.WriteLine("Não é domingo");
// }

// // SWITCH
// Console.WriteLine("Digite um número:");
// int diaSemana = Convert.ToInt32(Console.ReadLine());

// switch (diaSemana)
// {
//     case 0:
//         Console.WriteLine("Domingo");
//         break;
//     case 1:
//         Console.WriteLine("Segunda");
//         break;
//     case 2:
//         Console.WriteLine("Terça");
//         break;
//     case 3:
//         Console.WriteLine("Quarta");
//         break;
//     default:
//         Console.WriteLine("Inválido");
//         break;
// }

// // FOR 

// var listaFor = new List<string> ()
// {
//     "Rafael",
//     "Curso",
//     "C#"
// };

// for (var i = 0; i < listaFor.Count; i++)
// {
//     var nomeDaLista = listaFor [i];
//     Console.WriteLine(nomeDaLista);
// }

// // FOREACH - não precisa passar um indice i
// var listaForeach = new List<string> ()
// {
//     "Rafael",
//     "Curso",
//     "C#"
// };

// foreach (string item in listaForeach)
// {
//     Console.WriteLine(item);
// }

// foreach (var letra in "Rafael Almeida") // caminha por cada letra da string
// {
//     Console.WriteLine(letra);
// }

// // WHILE - faz a validação do valor primeiro e dps roda

// var t = 0;
// while(t < 6)
// {
//     Console.WriteLine(t);
//     t++;
// }

// // DO WHILE 
// var j = 0;
// do 
// {
//     Console.WriteLine(j);
//     j++;
// } while(j < 3);

// // BREAK, CONTINUE

// var contador = 0;
// while (contador < 10)
// {
//     if (contador < 1)
//     {
//         Console.WriteLine("A contagem vai começar...");
//         contador++;
//         continue;

//     }

//     Console.WriteLine("O valor do contador é " + contador);
//     contador++;

//     if (contador == 5)
//     {
//         Console.WriteLine("O valor do contador chegou a 5");
//         break;
//     }
// }



