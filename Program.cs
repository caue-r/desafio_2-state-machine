List<string> logs = new List<string> { "INFO", "WARN", "ERROR", "INFO", "ERROR", "ERROR", "CRITICAL", "INFO" };

int contadorError = 0;
int contadorCombo = 0;
bool alertaDisparado = false;

foreach (string log in logs)
{
    switch (log)
    {
        case "MAINTENANCE":
            continue;

        case "ERROR":
            contadorError++;
            contadorCombo = contadorCombo + 3;
            break;

        case "WARN":
            contadorCombo = contadorCombo + 1;
            contadorError = 0;
            break;

        case "CRITICAL":
            contadorCombo = contadorCombo + 10;
            contadorError = 0;
            break;

        case "REBOOT":
            contadorCombo = 0;
            contadorError = 0;
            break;

        default:
            contadorError = 0;
            break;
    }
    if (contadorError >= 3 || contadorCombo > 20)
    {
        alertaDisparado = true;
        break;
    }
}
if (alertaDisparado)
    Console.WriteLine("ALERTA DISPARADO");
else
    Console.WriteLine("Sistema Estável");
