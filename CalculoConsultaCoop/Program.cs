using System;

namespace CalculoConsultaCoop;

class Program 
{
     static void Main(string[] args) 
    {
        InformaConsultaTotal();

        
    }

    static void InformaConsultaTotal() 
    {
        Console.Clear();

        string nomePrestador;
        Console.Write("Informe o nome do Médico(a): ");
        nomePrestador = Console.ReadLine();

        string especialidade;
        Console.Write("Informe qual a especialidade do Médico(a): ");
        especialidade = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine($"Nome: {nomePrestador}");
        Console.WriteLine($"Especialidade: {especialidade}");


        Console.WriteLine("");

        Console.WriteLine("Caso você queira confirmar seus dados, informe uma opção: ");

        Console.WriteLine("");



        short respostaConfirmacao;
        Console.WriteLine("1 - Confirmar");
        Console.WriteLine("2 - Voltar");


        respostaConfirmacao = short.Parse((Console.ReadLine()));

        

        switch (respostaConfirmacao) 
        {
            case 1: Console.WriteLine("Você confirmou!"); PorcentagemConsultaCop(); break;
            case 2: InformaConsultaTotal(); break;
            default: Console.WriteLine("Vou tacar você lá pra frente"); break;
        }

        Console.ReadKey();
    }

    //static void InformaValorInteiroConsulta()
    //{
    //    Console.Clear();

    //    double respostaValorInteiroConsulta;
    //    Console.Write("Informe o valor total da consulta realizado pelo prestador: ");
    //    respostaValorInteiroConsulta = Convert.ToDouble(Console.ReadLine());

    //    Console.WriteLine($"Valor total da consulta: R${respostaValorInteiroConsulta}");

    //    Console.WriteLine("1 - Continuar");
    //    Console.WriteLine("2 - Voltar");
    //    Console.WriteLine("3 - Menu Informação da consulta");
    //    int respostaConfirmacao = Convert.ToInt32(Console.ReadLine());

    //    switch (respostaConfirmacao) 
    //    {
    //        case 1: Console.WriteLine("Continuar"); break;
    //        case 2: InformaValorInteiroConsulta(); break;
    //        case 3: InformaConsultaTotal(); break;
    //        default: Console.WriteLine("Vou te jogar lá no começo!"); break;
    //    }

    //    Console.ReadKey();
    //}

    static void PorcentagemConsultaCop() 
    {
        double respostaValorInteiroConsulta;
        Console.Write("Informe o valor inteiro da consulta: R$");
        respostaValorInteiroConsulta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        double totalConsultaRealizada;
        Console.Write("Informe o total de consultas realizadas pelo Doutor: ");
        totalConsultaRealizada = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        double respostaCop;
        Console.Write("Coparticipação: ");
        respostaCop = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");


        var calcularCop = respostaCop / 100.0; //Aqui vai descobrir o total da Porcentagem
        var mostrarPorcentagem = respostaValorInteiroConsulta - (calcularCop * respostaValorInteiroConsulta);
        var totalPagamentoMedico = totalConsultaRealizada * respostaValorInteiroConsulta;

        Console.WriteLine($"Valor total para o pagamento do prestador: R${totalPagamentoMedico}");

        Console.WriteLine("");

        Console.WriteLine($"Valor total da consulta com a coparticipação: R${mostrarPorcentagem}");

        Console.ReadKey();

        InformaConsultaTotal();
    }
}
