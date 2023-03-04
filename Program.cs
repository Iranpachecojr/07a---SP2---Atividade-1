using System;
namespace Proj_Atividade
{
    class Program
    {
        static void Main(string[]args)
        {
            float valPago;//Valor pago ao cliente
            Console.WriteLine("Nome do cliente: ");
            string varNome = Console.ReadLine();
            Console.WriteLine("Endereço do Cliente");
            string varEndereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física(f) ou Juridica(j)");
            string varTipo = Console.ReadLine();
            
            if(varTipo == "f")
            {
                PessoaFisica pf = new PessoaFisica();
                pf.nome = varNome;
                pf.end = varEndereco;
                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Digite o RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra");
                valPago = float.Parse(Console.ReadLine());
                pf.PagarImposto(valPago);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>Pessoa Fisica<<<<<<<<<<<<<<<");
                Console.WriteLine("Nome: " + pf.nome);
                Console.WriteLine("Endereço: "+ pf.end);
                Console.WriteLine("CPF: "+pf.cpf);
                Console.WriteLine("RG: "+pf.rg);
                Console.WriteLine("Valor da Compra: "+pf.valor.ToString("C"));
                Console.WriteLine("Valor do Imposto: "+pf.valorImposto.ToString("C"));
                Console.WriteLine("Valor Total: "+pf.valorTotal.ToString("C"));
            }
            if(varTipo == "j")
            {
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = varNome;
                pj.end = varEndereco;
                Console.WriteLine("CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe sua Insc. Estatual");
                pj.inscEst = Console.ReadLine();
                Console.WriteLine("Informe o valor da Compra: ");
                valPago = float.Parse(Console.ReadLine());
                pj.PagarImposto(valPago);
                Console.WriteLine(">>>>>>>>>>>>>>>>>>Pessoa Fisica<<<<<<<<<<<<<<<");
                Console.WriteLine("Nome: "+pj.nome);
                Console.WriteLine("Endereço: "+pj.end);
                Console.WriteLine("CNPJ: "+pj.cnpj);
                Console.WriteLine("Insc. Estadual: "+pj.inscEst);
                Console.WriteLine("Valor da Compra: "+pj.valor.ToString("C"));
                Console.WriteLine("Imposto: "+pj.valorImposto.ToString("C"));
                Console.WriteLine("Total: "+pj.valorTotal.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção invalida.");
            }
        }
    }
}
