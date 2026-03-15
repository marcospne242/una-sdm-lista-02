using System;
using Lista02.Models;

Peca peca = new Peca
{
    Id = 1,
    Nome = "Martelo",
    Tipo = "Ferramenta manual",
    Quantidade = 10,
    Preco = 29.90
};

Console.WriteLine($"Peça: {peca.Nome} | Quantidade: {peca.Quantidade}");

veiculo veiculo = new veiculo
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Ano = 2022,
    Preco = 120000
};

Console.WriteLine($"Veículo: {veiculo.Marca} {veiculo.Modelo}");

livro livro = new livro
{
    Titulo = "Dom Casmurro",
    Autor = "Machado de Assis",
    Ano = 1899,
    Genero = "Romance"
};

Console.WriteLine($"Livro: {livro.Titulo} - {livro.Autor}");

universidade universidade = new universidade
{
    Nome = "Centro Universitário UNA",
    Cidade = "Belo Horizonte",
    Estado = "MG",
    NumeroAlunos = 20000
};

Console.WriteLine($"Universidade: {universidade.Nome}");

shopping shopping = new shopping
{
    Nome = "Shopping Central",
    Cidade = "Belo Horizonte",
    NumeroLojas = 150,
    NumeroRestaurantes = 25,
    PossuiCinema = true
};

Console.WriteLine($"Shopping: {shopping.Nome}");

