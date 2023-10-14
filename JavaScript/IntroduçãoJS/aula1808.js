
// ----- Loops ----- //

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