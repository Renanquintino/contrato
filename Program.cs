using System;
using System.Globalization;
using exercicio.Entidade;
using exercicio.Service;
using exercicio.Serviço;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Numero do contrato: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);


            Console.Write("Entre com o numero de parcelas: ");
            int month = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ContractService contractService = new ContractService(new PayPolService());
            contractService.ProcessContract(contract, month);

            Console.WriteLine(  );
            Console.WriteLine("Parcelamento");

            foreach (Installment installment in contract.Installment)
            {
                Console.WriteLine(installment);
            }
        
        }
    }
}
