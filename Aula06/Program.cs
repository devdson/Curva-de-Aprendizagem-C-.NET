using System;

namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.Writeline("=====Operadores Lógicos=====");

        bool logged = true;
        bool admin = true;


        // Operador ( || ) - OU
        if ( logged || admin ) {

            Console.Writeline("Acesso ao sistema concedido.");

        } else {

            Console.Writeline("Acesso ao sistema negado.");
        }

        // Operador (&&) - E

        if (logged && admin) {

            Console.Writeline("Acesso ao painel de administração concedido.");

        } else {

            Console.Writeline("Acesso ao painel de administração negado. ");
        }

        // Operador (!) - Negação

        if (!logged) {

            Console.Writeline("Acesso ao sistema negado.");

        } else {

            Console.Writeline("Acesso ao sistema concedido.");

        }
    }
}