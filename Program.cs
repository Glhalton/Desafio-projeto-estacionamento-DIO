using DesafioFundamentos.Models;

int escolha = 0;
bool menu = true;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento est = new Estacionamento(precoInicial, precoHora);

while (menu)
{
    Console.Clear();
    Console.WriteLine(
        "Digite a sua opção:\n" +
        "1 - Cadastrar veículo\n" +
        "2 - Remover veículo\n" +
        "3 - Listar veículos\n" +
        "4 - Encerrar"
        );

    escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placaCadastro = Console.ReadLine();

            est.AdicinarVeiculo(placaCadastro);

            break;
        case 2:
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaRemocao = Console.ReadLine();

            est.RemoverVeiculo(placaRemocao);

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());

            decimal valorTotal = est.CalcularPrecoEstacionamento(quantidadeHoras);
            Console.WriteLine($"O veículo {placaRemocao} foi removido e o preço total foi de: R$ {valorTotal}");

            break;
        case 3:
            Console.WriteLine("Os veículos estacionados são:");

            est.ListarVeiculos();

            break;
        case 4:
            menu = false;
            break;
    }
    
    
    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadLine();
}
