using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeKind_basico {
    internal class Program {
        static void Main(string[] args) {
            //1º data sistema local /2 º UTC fuso horario Greenwich 3 horas atrasado (Londres) mean time//3º Unspecified
            //armazenar em UTC (universal)
            //porem na hora de mostrar para o usuario e necessario instancia em formato local 
            //consequentemente o usuario ira verificar o horario local ( de sua regiao)
            DateTime Datalocal = new DateTime(2000, 08, 11,20,30,55, DateTimeKind.Local);
            DateTime D2 = new DateTime(2000, 08, 11, 20, 30, 55, DateTimeKind.Utc);
            DateTime D3 = new DateTime(2000, 08, 11, 20, 30, 55);

            Console.WriteLine("Data Local: " +Datalocal);
            Console.WriteLine("Data Kind : " + Datalocal.Kind) ;
            Console.WriteLine("Data to local : " +Datalocal.ToLocalTime());
            Console.WriteLine("DataLocal to UTC: 3 HORAS (Londres) " + Datalocal.ToUniversalTime());
            Console.WriteLine() ;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Data Local: " + D2);
            Console.WriteLine("Data Kind : " + D2.Kind);
            Console.WriteLine("Data to local volta 3 horas green Londres : " + D2.ToLocalTime());
            Console.WriteLine("DataLocal to UTC: 3 HORAS (Londres) " + D2.ToUniversalTime());
            
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("---basicamente não se sabe quanto e utc ou local a hora-----------");
            //utlizando o metodo universal  Unspecified
            Console.WriteLine("Data Local: " + D3);
            Console.WriteLine("Data Kind : " + D3.Kind);
            Console.WriteLine("Data to local 3 horas menos : " + D3.ToLocalTime());
            Console.WriteLine("DataLocal to UTC: 3 HORAS (Londres) " + D3.ToUniversalTime());


        }
    }
}
