console.log("Hello, World!");

const idadeTeste = 26;
console.log("A idade do doido: " + idadeTeste);

const idadeSomada = idadeTeste + 2;
console.log(idadeSomada);
// CamelCase nas variáveis e JS é case sensitive

console.log("A idade do doido somada mais dois", idadeTeste + 2);



// ----- Trabalhando com variáveis ----- //

const idadeRicardo = 29;
const nomeRicardo = "ricardo";
let ano = 2023;
mes = "janeiro"; // não fazer

// ----- Atribuição de variáveis ----- //

const idade = 29;
let primeiroNome; // pode ser atribuído depois, mas o const precisa ser atribuído na criação
primeiroNome = "ricardo";
const sobrenome = "bugan";

console.log(primeiroNome, sobrenome);
console.log(primeiroNome + " " + sobrenome);
console.log(`Meu nome é ${primeiroNome} e meu sobrenome é ${sobrenome}`);

nomeCompleto = primeiroNome + sobrenome; // funciona se a variável for let e não const
console.log(primeiroNome);

// ----- Operações aritmétricas ----- //

console.log(10 + 8 * 2);
console.log((10 + 8) * 2);

console.log("ano " + 2020);
console.log("ano", 2020);

// -----  Conversão de tipos ----- //

console.log(parseInt("2") + 3); // conversão explícita
console.log("10" / "2"); // conversão implícita
console.log("Ricardo" / "2"); // not a number NaN

// ----- Listas ----- //

const salvador = `Salvador`;
const rioDeJaneiro = `Rio de Janeiro`;
const saoPaulo = `São Paulo`;
// passar dessa forma não é uma boa prática 

const listaDeDestinos = new Array(
    `Salvador`,
    `Rio de Janeiro`,
    `São Paulo`
);

console.log(listaDeDestinos);

listaDeDestinos.push(`Curitiba`) // add novo elemento na lista 
console.log(listaDeDestinos);

listaDeDestinos.splice(1, 1) // retirando elemento 'Rio de Janeiro' da lista (primeiro número é a posição, a quantidade de elementos retirados)
console.log(listaDeDestinos);

console.log(listaDeDestinos[0]); // imprime o primeiro elemento da lista

// ----- Operadores Condicionais ----- //

const listaDeDestinosCondicionais = new Array(
    `Salvador`,
    `Rio de Janeiro`,
    `São Paulo`
);

const idadeComprador = 12;
const estaAcompanhada = true;
const temPassagemComprada = true;

if (idadeComprador >= 18 || estaAcompanhada == true) {
    console.log("Comprador maior de idade ou menor de idade acompanhado.");
    listaDeDestinosCondicionais.splice(0, 1);
} else {
    console.log("Comprador menor de idade, compra não realizada!");
    console.log(`Destinos possíveis`, listaDeDestinosCondicionais);
}

if (temPassagemComprada == true && (estaAcompanhada == true || idadeComprador >= 18)) {
    console.log("Boa viagem!");
} else {
    console.log("Realize a compra da passagem.");
}

console.log(listaDeDestinosCondicionais);
