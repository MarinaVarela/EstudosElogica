//  Autoras e livros
const biblioteca = [
    { autora: "Cora Coralina", livro: "Poemas dos Becos de Goiás e estórias mais (poesia)", ano: 1965, editora: "Editora José Olympio", emprestado: false },
    { autora: "Cora Coralina", livro: "Meu Livro de Cordel", ano: 1976, editora: null, emprestado: true },

    { autora: "Cecília Meireles", livro: "Romanceiro da Inconfidência", ano: 1953, editora: "ELivros d Portugal", emprestado: false },
    { autora: "Cecília Meireles", livro: "Espectros", ano: 1919, editora: null, emprestado: true },

    { autora: "Lygia Fagundes Telles", livro: "As Meninas", ano: 1973, editora: "Companhia das Letras", emprestado: true },
    { autora: "Lygia Fagundes Telles", livro: "Seminário dos Ratos", ano: 1998, editora: "Companhia das Letras", emprestado: false },

    { autora: "Clarice Lispector", livro: "A Hora da Estrela", ano: 1977, editora: "Rocco", emprestado: false },
    { autora: "Clarice Lispector", livro: "Água Viva", ano: 1973, editora: "Rocco", emprestado: false },
];

// Função para exibir todos os livros
function exibirLivros(livros) {
    const sectionLivros = document.querySelector(".container-livros");
    sectionLivros.innerHTML = "";

    livros.forEach(item => {
        const emprestado = item.emprestado ? "Emprestado" : "Não emprestado"; //ternário para boolean
        const livroInfo = `${item.livro} - ${item.autora} (${item.ano}, ${item.editora || "Editora desconhecida"}) - ${emprestado}`;

        const livroDiv = document.createElement("div");
        livroDiv.innerHTML = `
        <p class="livro__info">${livroInfo}</p>
        <label class="livro__checkbox" for="emprestado-${item.livro}">Empréstimo:</label>
        <input class="livro__checkbox" type="checkbox" id="emprestado-${item.livro}" ${item.emprestado ? "checked" : ""} onchange="atualizarEmprestimo('${item.livro}')">`;

        sectionLivros.appendChild(livroDiv);
    });
}

// Função filtro por autora
function filtrarPorAutora() {
    const autoraSelecionada = document.getElementById("filtroAutora").value;

    if (autoraSelecionada === "all") {
        exibirLivros(biblioteca);
    } else {
        const livrosFiltrados = biblioteca.filter(item => item.autora === autoraSelecionada);
        exibirLivros(livrosFiltrados);
    }
}

// Função filtro por livro
function filtrarPorLivro() {
    const livroSelecionado = document.getElementById("filtroLivro").value;

    if (livroSelecionado === "all") {
        exibirLivros(biblioteca);
    } else {
        const livrosFiltrados = biblioteca.filter(item => item.livro === livroSelecionado);
        exibirLivros(livrosFiltrados);
    }
}

// Função check empréstimo
function atualizarEmprestimo(livro) {
    const livroSelecionado = biblioteca.find(item => item.livro === livro);

    if (livroSelecionado) {
        livroSelecionado.emprestado = !livroSelecionado.emprestado; //negando a informação
        exibirLivros(biblioteca);
    }
}

// Exibição de todos os livros
document.addEventListener("DOMContentLoaded", function () {
    exibirLivros(biblioteca);
});


