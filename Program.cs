List<string> logs = new List<string>{ "INFO", "WARN", "ERROR", "INFO", "ERROR", "ERROR", "CRITICAL", "INFO"};

int contadorError = 0;
int contadorCombo = 0;
bool alertaDisparado = false;

foreach (string log in logs)
{   
    if(contadorError>= 3 || contadorCombo > 20)
    {
        alertaDisparado = true;
        break;
    }
    switch (log)
    {
        case "ERROR": contadorError ++; contadorCombo += 3; break;

        case "WARN": contadorCombo =+ 1; contadorError = 0; break;

        case "CRITICAL": contadorCombo =+10; contadorError = 0; break;

        case "REBOOT": contadorCombo = 0; contadorError = 0; break;

        default: break;
    }
}

if (alertaDisparado)
    Console.WriteLine("ALERTA DISPARADO");
else
    Console.WriteLine("Sistema Estável");