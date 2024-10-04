using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
var hospedes = new List<Pessoa>();

var p1 = new Pessoa(nome: "Fulano");
var p2 = new Pessoa(nome: "Beltrano", sobrenome: "silva campos");

hospedes.Add(p1);
hospedes.Add(p2);

// Exibe o nome dos hóspedes
Console.WriteLine("Lista de hóspedes");
Console.WriteLine(string.Join('\n', hospedes.Select(e => $"- {e.NomeCompleto}")) + '\n');

// Cria a suíte
var suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
var reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
