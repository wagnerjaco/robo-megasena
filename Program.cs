using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace robo_megasena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero do concurso ");
            string numerodoconcurso = Console.ReadLine();

            Console.WriteLine(numerodoconcurso);

            if(string.IsNullOrWhiteSpace( numerodoconcurso))
            {
                numerodoconcurso = "2103";
            }

            string url = @"http://www1.caixa.gov.br/loterias/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso=" + numerodoconcurso;
            string html;

            using (WebClient wc = new WebClient())
            {
                wc.Headers["cookie"] = "security =true";
                html = wc.DownloadString(url);

            }
            Console.ReadKey();


           


        }
    }
}
