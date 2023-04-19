// cadastro de usuario e senha
// sistema de login com usuario e senha
// menu
// exibir saldo
// opcao de deposito
// opcao de saque, que atualize o saldo

bool loopBreak = false;
string opcaoLogin = "";
string[] usuario = new string[5];
string[] senha = new string[5];
int saldo = 1000;
int pos = 0;

do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
---------------------------
|      Seja bem vindo     |
|   (1) Entrar na conta   |
|   (2) Criar uma conta   |
|   (0) Encerrar          |
---------------------------
    ");
    Console.ResetColor();

    opcaoLogin = Console.ReadLine();

    switch (opcaoLogin)
    {
        case "1":
            Console.WriteLine($"entrar na conta");
            Console.WriteLine($"usuario:");
            string usuarioPesquisa = Console.ReadLine();

            Console.WriteLine($"senha:");
            string senhaPesquisa = Console.ReadLine();

            if (usuario.Contains(usuarioPesquisa) && senha.Contains(senhaPesquisa))
            {
                conta();
            }
            loopBreak = true;
            break;

        case "2":
            Console.WriteLine(@$"-- Criar conta --");
            Console.WriteLine($"Digite user");
            usuario[pos] = Console.ReadLine();

            Console.WriteLine($"Digite senha");
            senha[pos] = Console.ReadLine();
            pos++;
            break;

        case "0":
            Console.WriteLine($"Ate mais");
            loopBreak = true;
            break;

        default:
            Console.WriteLine($"Erro, programa encerrado");
            loopBreak = true;
            break;
    }

} while (loopBreak == false);

void conta()
{
    Console.WriteLine(@$"
| ola {usuario[pos - 1]} |

saldo: {saldo}

(1) Depositar
(2) Saque
(0) sair
");
    
}