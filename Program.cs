﻿using Desafio21DiasPOO;
using DesafioPOO.Models;
using DesafioPOO.Interfaces;
using DesafioPOO.Helper;



Gato animal = new Gato(){Nome= "Gato"};
try
{
    animal.Andar();
}
catch (AnimalException e)
{
    Console.WriteLine(e.Message);
}





/* Juridica empresa = new Juridica() { Nome = "Distribuidora vitória", CNPJ = "1235541221" };
Servicos.Salvar(empresa);
Juridica empresa1 = new Juridica() { Nome = "casas marlim", CNPJ = "1235541221" };
Servicos.Salvar(empresa1);

//Servicos.Excluir(empresa1);

Servicos.Busca(empresa); */








/*     // Adicionando pessoas fisicas com o objeto sendo salvo por ele mesmo
    new Fisica() { Nome = "joao ricardo", Endereco = "Rua sao paulo", CPF = "798.654.987-62" }.Salvar();
new Fisica() { Nome = "pedro jose", Endereco = "Rua 3 de abril", CPF = "123.654.568-70" }.Salvar();
new Fisica() { Nome = "jose ricardo", Endereco = "Rua E", CPF = "145.478.987-80" }.Salvar();

//Adicionando e salvando pela instancia, mais código!
Fisica usuario = new Fisica() { Nome = "maria roas", Endereco = "Rua sao paulo", CPF = "798.654.987-62" };
Fisica usuario1 = new Fisica() { Nome = "higor ricardo", Endereco = "Rua abrao laures", CPF = "123.852.987-90" };
Fisica usuario2 = new Fisica() { Nome = "yasmim zane", Endereco = "Rua eugenio maquezini", CPF = "568.741.987-54" };

Fisica.SalvarInstancia(usuario);
Fisica.SalvarInstancia(usuario1);
Fisica.SalvarInstancia(usuario2);

var lista = Fisica.BuscarTodos();
foreach (var pessoas in lista)
{
    Console.WriteLine($"Nome: {pessoas.Nome} Endereço: {pessoas.Endereco} CPF: {pessoas.CPF} \n");
    Console.WriteLine("=======================================================================");
}

var lista2 = Fisica.PorNome("Ricardo");
foreach (var pessoas in lista2)
{
    Console.WriteLine($"Nome: {pessoas.Nome} Endereço: {pessoas.Endereco} CPF: {pessoas.CPF}");
} */
