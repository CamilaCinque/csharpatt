
// herança -> uma classe derivada de uma superclasse (atributos, métodos)
// abstração -> isolar somente as informações mais relevantes
// polimorfismo -> muitas formas de executar o mesmo método 
// encapsulamento -> como os atributos podem ser acessados

// classes -> molde, modelo
// objeto -> instância de uma classe (new)

// atributos e métodos
// atributos -> características do objeto (variáveis que guardam informações de um objeto)
// métodos -> funções que determinam os comportamentos do objeto

// criar um objeto

using POO;

Carro carro = new Carro(); 
Moto moto = new Moto();
ContaBancaria cb = new ContaBancaria();

//carro.marca =  "FIAT";
//carro.modelo = "Argo";
//carro.ano = 2026;
//carro.valor = 123000;
//carro.cor = "Vermelho";

//carro.ExibirDetalhes();

//moto.marca = "Suzuki";
//moto.modelo = "Hayabusa";
//moto.ano = 2020;
//moto.temPartidaEletrica = true;

//moto.ExibirDetalhes();

cb.Depositar(250.00);
cb.MostrarSaldo();
cb.Sacar(20.00);
cb.MostrarSaldo();