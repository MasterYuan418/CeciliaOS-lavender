﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Help infos
* PROGRAMMERS:      Alexy DA CRUZ <dacruzalexy@gmail.com>
*                   Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using Shell = Aura_OS.System.Shell;
//using Cosmos.HAL.PCInformation;
using System;
using Cosmos.HAL;
using Cosmos.Core;

namespace Aura_OS.System.Translation
{
    class List_Translation
    {

        /// <summary>
        /// Display help on general commands.
        /// </summary>
        public static void _Help()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Commandes disponibles (1/2):");
                    Console.WriteLine("- shutdown (arrêt ACPI)");
                    Console.WriteLine("- reboot (redémarrage CPU)");
                    Console.WriteLine("- clear (efface la console)");
                    Console.WriteLine("- cd .. (pour naviguer dans le dossier parent)");
                    Console.WriteLine("- cd (pour aller à un dossier)");
                    Console.WriteLine("- dir (liste les fichiers et dossiers)");
                    Console.WriteLine("- ls (liste les fichiers et dossiers)");
                    Console.WriteLine("- cp (pour copier un fichier à une autre destination)");
                    Console.WriteLine("- mkdir (pour créer un dossier)");
                    Console.WriteLine("- rmdir (pour supprimer un dossier)");
                    Console.WriteLine("- mkfil (pour créer un fichier)");
                    Console.WriteLine("- rmfil (pour supprimer un fichier)");
                    Console.WriteLine("- edit (pour éditer un fichier)");
                    Console.WriteLine("- vol (list les volumes FAT)");
                    Console.WriteLine("- echo (affiche un echo)");
                    Console.WriteLine("- systeminfo (affiche des informations systeme)");
                    Console.WriteLine("- ver (pour afficher la version système)");
                    Console.WriteLine("- settings {args} (permet d'accéder aux paramètres)");
                    Console.WriteLine("- logout (permet de se déconnecter)");
                    
                    if(AConsole.KeyboardShortcuts.Close())
                    {
                        return;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Commandes disponibles (2/2):");
                    Console.WriteLine("- time (récupère la date et l'heure)");
                    Console.WriteLine("- ipconfig (affiche les informations réseau)");
                    Console.WriteLine("- snake (lance le jeu Snake)");
                    Console.WriteLine("- md5 (affiche le hash des arguments)");
                    Console.WriteLine("- sha256 (affiche le hash des arguments)");
                    Console.WriteLine("- crash (crash Aura)");
                    Console.WriteLine("- crashcpu (crash CPU)");
                    Console.WriteLine("- lspci (liste les appareils pci)");
                    Console.WriteLine("- beep (beep)");
                    Console.WriteLine("- debug {args} (informations utiles au debug)");

                    Console.ReadKey();

                    break;

                case "en_US":
                    Console.WriteLine("Available commands (1/2):");
                    Console.WriteLine("- shutdown (to do an ACPI Shutdown)");
                    Console.WriteLine("- reboot (to do a CPU Reboot)");
                    Console.WriteLine("- clear (to clear the console)");
                    Console.WriteLine("- cd .. (to navigate to the parent folder)");
                    Console.WriteLine("- cd (to navigate to a folder)");
                    Console.WriteLine("- dir (to list directories and files)");
                    Console.WriteLine("- ls (to list directories and files)");
                    Console.WriteLine("- cp (to copy a file to an another destination)");
                    Console.WriteLine("- mkdir (to create a directory");
                    Console.WriteLine("- rmdir (to remove a directory)");
                    Console.WriteLine("- mkfil (to create a file)");
                    Console.WriteLine("- rmfil (to remove a file)");
                    Console.WriteLine("- edit (to edit a file)");
                    Console.WriteLine("- vol (to list volumes)");
                    Console.WriteLine("- echo (to echo text)");
                    Console.WriteLine("- systeminfo (to display system information)");
                    Console.WriteLine("- ver (to display system version)");
                    Console.WriteLine("- settings {args} (access to settings)");
                    Console.WriteLine("- logout (to disconnect)");

                    if (AConsole.KeyboardShortcuts.Close())
                    {
                        return;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Available commands (2/2):");
                    Console.WriteLine("- time (to get time and date)");
                    Console.WriteLine("- ipconfig (to get network information)");
                    Console.WriteLine("- snake (launch the game Snake)");
                    Console.WriteLine("- md5 (to display hash of arguments)");
                    Console.WriteLine("- sha256 (to display hash of arguments)");
                    Console.WriteLine("- crash (crash Aura)");
                    Console.WriteLine("- crashcpu (crash CPU)");
                    Console.WriteLine("- lspci (list pci devices)");
                    Console.WriteLine("- beep (beep)");
                    Console.WriteLine("- debug {args} (useful information for debugging)");

                    Console.ReadKey();

                    break;

                case "nl_NL":
                    Console.WriteLine("Mogelijke commando's (1/2):");
                    Console.WriteLine("- shutdown (om een ACPI-shutdown te doen)");
                    Console.WriteLine("- reboot (opnieuw opstarten met de CPU)");
                    Console.WriteLine("- clear (om de console leeg te maken)");
                    Console.WriteLine("- cd .. (om naar de bovenliggende map te navigeren)");
                    Console.WriteLine("- cd (om te navigeren naar een folder)");
                    Console.WriteLine("- dir (geeft een weergave van mappen en bestanden)");
                    Console.WriteLine("- ls (geeft een weergave van mappen en bestanden)");
                    Console.WriteLine("- cp (om een bestand naar een andere bestemming te kopiëren)");
                    Console.WriteLine("- mkdir (om een map te maken");
                    Console.WriteLine("- rmdir (om een map te verwijderen)");
                    Console.WriteLine("- mkfil (om een bestand aan te maken)");
                    Console.WriteLine("- rmfil (om een bestand te verwijderen)");
                    Console.WriteLine("- edit (om een bestand te bewerken)");
                    Console.WriteLine("- vol (geeft een lijst met volumes)");
                    Console.WriteLine("- echo (om tekst te echoën)");
                    Console.WriteLine("- systeminfo (om systeeminformatie te weergeven)");
                    Console.WriteLine("- ver (om de systeemversie weer te geven)");
                    Console.WriteLine("- settings {argumenten} (toegang tot instellingen)");
                    Console.WriteLine("- logout (om los te koppelen)");

                    if (AConsole.KeyboardShortcuts.Close())
                    {
                        return;
                    }
                    //page 2 (19 elements per page)

                    Console.WriteLine();
                    Console.WriteLine("Mogelijke commando's (2/2):");
                    Console.WriteLine("- time (om tijd en datum te verkrijgen)");
                    Console.WriteLine("- ipconfig (om netwerk informatie te verkrijgen)");
                    Console.WriteLine("- snake (start het spel Snake)");
                    Console.WriteLine("- md5 (om de hash van argumenten weer te geven)");
                    Console.WriteLine("- sha256 (om de hash van argumenten weer te geven)");
                    Console.WriteLine("- crash (crasht Aura)");
                    Console.WriteLine("- crashcpu (crasht CPU)");
                    Console.WriteLine("- lspci (lijst pci-apparaten)");
                    Console.WriteLine("- beep (beep)");
                    Console.WriteLine("- debug {args} (nuttige informatie voor debuggen)");

                    Console.ReadKey();

                    break;
                    
                    case "it_IT":
                    Console.WriteLine("Comandi disponibili (1/2):");
                    Console.WriteLine("- shutdown (per eseguire un ACPI shutdown)");
                    Console.WriteLine("- reboot (per riavviare la CPU)");
                    Console.WriteLine("- clear (per pulire la console)");
                    Console.WriteLine("- cd .. (per navigare la cartella principale)");
                    Console.WriteLine("- cd (per accedere and una cartella)");
                    Console.WriteLine("- dir (per elencare le cartelle ed i files)");
                    Console.WriteLine("- ls (per elencare le cartelle ed i file)");
                    Console.WriteLine("- cp (per copiare un file in un' altra destinazione)");
                    Console.WriteLine("- mkdir (per creare una cartella)");
                    Console.WriteLine("- rmdir (per eliminare una cartella))");
                    Console.WriteLine("- mkfil (per creare un file)");
                    Console.WriteLine("- rmfil (per eliminare un file)");
                    Console.WriteLine("- edit (per modificare un file)");
                    Console.WriteLine("- vol (per elencare i volumi)");
                    Console.WriteLine("- echo (per eseguire l'echo di  un testo)");
                    Console.WriteLine("- systeminfo (per visualizzare le informazioni di sistema)");
                    Console.WriteLine("- ver (per visualizzare la versione del sistema)");
                    Console.WriteLine("- settings {args} (accedi ai settaggi)");
                    Console.WriteLine("- logout (per disconnetterti)");
                    
                    Console.ReadKey(); //page 2 (19 elements per page)

                    Console.WriteLine();
                    Console.WriteLine("Comandi disponibili (2/2):");
                    Console.WriteLine("- time (per visualizzare data e ora)");
                    Console.WriteLine("- ipconfig (per visualizzare le informazioni di rete)");
                    Console.WriteLine("- snake (avvia il gioco Snake)");
                    Console.WriteLine("- md5 (per visualizzare l'hash degli argomenti)");
                    Console.WriteLine("- sha256 (per visualizzare l'hash degli argomenti)");
                    Console.WriteLine("- crash (crash Aura)");
                    Console.WriteLine("- crashcpu (crash CPU)");
                    Console.WriteLine("- lspci (elenco dispositivi PCI)");
                    Console.WriteLine("- beep (beep)");
                    Console.WriteLine("- debug {args} (informazioni utili per il debug)");

                    Console.ReadKey();

                    break;
                    
                    
                case "pl_PL":
                    Console.WriteLine("Dostepne komedy (1/2):");
                    Console.WriteLine("- shutdown (do zmkniecia systemu (ACPI))");
                    Console.WriteLine("- reboot (do restartu komputera)");
                    Console.WriteLine("- clear (do czyszczenia konsoli)");
                    Console.WriteLine("- cd .. (do przejscia do katalogu nadrzednego)");
                    Console.WriteLine("- cd (do zmiany katalogu)");
                    Console.WriteLine("- dir (do wyswietlenia wszystkich plikow i katalogow)");
                    Console.WriteLine("- ls (do wyswietlenia wszystkich plikow i katalogow)");
                    Console.WriteLine("- cp (do kopiowania plikow)");
                    Console.WriteLine("- mkdir (do tworzenia katalogow");
                    Console.WriteLine("- rmdir (do usuwania katalogow)");
                    Console.WriteLine("- mkfil (do tworzenia plikow)");
                    Console.WriteLine("- rmfil (do usuwania plikow)");
                    Console.WriteLine("- edit (do edytowania plikow)");
                    Console.WriteLine("- vol (do wyswietlania woluminow)");
                    Console.WriteLine("- echo (do zwracania tekstu)");
                    Console.WriteLine("- systeminfo (do wyswietlenia informacji o systemie)");
                    Console.WriteLine("- ver (do wyswietlenia wersji systemu)");
                    Console.WriteLine("- settings {args} (dostep do ustawien)");
                    Console.WriteLine("- logout (do wylogowania)");

                    if (AConsole.KeyboardShortcuts.Close())
                    {
                        return;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Available commands (2/2):");
                    Console.WriteLine("- time (do wyswietlania daty i godziny)");
                    Console.WriteLine("- ipconfig (do wyswietlania informacji o sieci");
                    Console.WriteLine("- snake (do wlaczenia gry Snake)");
                    Console.WriteLine("- md5 (do wyswietlenia haszu argumentow)");
                    Console.WriteLine("- sha256 (do wyswietlenia haszu argumentow)");
                    Console.WriteLine("- crash (do wykonania crashtestu systemu)");
                    Console.WriteLine("- crashcpu (crash CPU (dzielenie przez 0)");
                    Console.WriteLine("- lspci (do wyswietlenia urzadzen PCI)");
                    Console.WriteLine("- beep (beep)");
                    Console.WriteLine("- debug {args} (informacje do debugowania)");

                    Console.ReadKey();

                    break;
            }
        }

        /// <summary>
        /// Display help on settings commands.
        /// </summary>
        public static void Settings()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Commandes disponible:");
                    Console.WriteLine("- adduser {user} {pass} (pour créer un compte)");
                    Console.WriteLine("- remuser {user} (pour supprimer un compte)");
                    Console.WriteLine("- passuser {user} {pass} (pour changer le mot de passe)");
                    Console.WriteLine("- setcomputername (pour changer le nom de l'ordinateur)");
                    Console.WriteLine("- setlang {lang} (pour changer la langue du système)");
                    //Console.WriteLine("- consolemode {mode} (pour changer le mode video de la console)");
                    Console.WriteLine("- debugger (pour configurer le debugger)");
                    Console.WriteLine("- ipaddress (pour changer l'adresse IP du PC)");
                    break;

                case "en_US":
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("- adduser {user} {pass} (to create an account)");
                    Console.WriteLine("- remuser {user} (to remove an account)");
                    Console.WriteLine("- passuser {user} {pass} (to change password)");
                    Console.WriteLine("- setcomputername (to change the computer name)");
                    Console.WriteLine("- setlang {lang} (to change the system language)");
                    //Console.WriteLine("- consolemode {mode} (to change the video mode of the console)");
                    Console.WriteLine("- debugger (to configure the debugger)");
                    Console.WriteLine("- ipaddress (to change the IP address of the PC)");
                    break;

                case "nl_NL":
                    Console.WriteLine("Mogelijke commando's:");
                    Console.WriteLine("- adduser {gebruiker} {wachtwoord} (om een account aan te maken)");
                    Console.WriteLine("- remuser {gebruiker} (om een account te verwijderen)");
                    Console.WriteLine("- passuser {gebruiker} {wachtwoord} (om het wachtwoord te veranderen)");
                    Console.WriteLine("- setcomputername (om de naam van de computer te veranderen)");
                    Console.WriteLine("- setlang {lang} (om de systeemtaal aan te passen)");
                    //Console.WriteLine("- consolemode {mode} (om de videomodus van de console te wijzigen)");
                    Console.WriteLine("- debugger (om de debugger te configureren)");
                    Console.WriteLine("- ipaddress (om het IP-adres van de PC te wijzigen)");
                    break;
                    
                case "it_IT":
                    Console.WriteLine("Comandi disponibili:");
                    Console.WriteLine("- adduser {user} {pass} (per creare un account)");
                    Console.WriteLine("- remuser {user} (per rimuovere un account)");
                    Console.WriteLine("- passuser {user} {pass} (per cambiare la password)");
                    Console.WriteLine("- setcomputername (per cambiare il nome del computer)");
                    Console.WriteLine("- setlang {lang} (per cambiare la lingua di sistema)");
                    //Console.WriteLine("- consolemode {mode} (om de videomodus van de console te wijzigen)");
                    Console.WriteLine("- debugger {lang} (per configurare il debugger)");
                    Console.WriteLine("- ipaddress (per modificare l'indirizzo IP del PC)");
                    break;
                    
                case "pl_PL":
                    Console.WriteLine("Dostepne komendy:");
                    Console.WriteLine("- adduser {user} {pass} (do tworzenia konta)");
                    Console.WriteLine("- remuser {user} (do usuwania konta)");
                    Console.WriteLine("- passuser {user} {pass} (do zmiany hasla)");
                    Console.WriteLine("- setcomputername (do zmiany nazwy komputera)");
                    Console.WriteLine("- setlang {lang} (do zmiany jezyka)");
                    //Console.WriteLine("- consolemode {mode} (do zmiany trybu konsoli)");
                    Console.WriteLine("- debugger (do konfiguracji debugera)");
                    Console.WriteLine("- ipaddress (do zmiany adresu IP)");
                    break;
            }
        }

        /// <summary>
        /// Display help on settings commands.
        /// </summary>
        public static void Systeminfo()
        {
            Utils.Settings config = new Utils.Settings(@"0:\System\settings.conf");
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("Nom du PC:                     " + Kernel.ComputerName);
                    Console.WriteLine("Nom du système d'exploitation: Aura");
                    Console.WriteLine("Version du système:            " + Kernel.version);
                    Console.WriteLine("Révision du système:           " + Kernel.revision);
                    Console.WriteLine("Date et heure:                 " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Date d'installation originale: " + config.GetValue("setuptime"));
                    }
                    Console.WriteLine("Heure de démarrage du système: " + Kernel.boottime);
                    Console.WriteLine("Mémoire totale:                " + Core.MemoryManager.TotalMemory + "MB");
                    Console.WriteLine("Mémoire utilisée:              " + Core.MemoryManager.GetUsedMemory() + "MB");
                    Console.WriteLine("Mémoire restante:              " + Core.MemoryManager.GetFreeMemory() + "MB");
                    Console.WriteLine("Processeur(s):                 " + CPU.GetCPUBrandString());
                    Console.WriteLine("Mode de la console:            " + Kernel.AConsole.Name);
                    break;

                case "en_US":
                    Console.WriteLine("Computer name:             " + Kernel.ComputerName);
                    Console.WriteLine("Operating system name:     Aura");
                    Console.WriteLine("Operating system version:  " + Kernel.version);
                    Console.WriteLine("Operating system revision: " + Kernel.revision);
                    Console.WriteLine("Date and time:             " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Original Install Date:     " + config.GetValue("setuptime"));
                    }
                    Console.WriteLine("System Boot Time:          " + Kernel.boottime);
                    Console.WriteLine("Total memory:              " + Core.MemoryManager.TotalMemory + "MB");
                    Console.WriteLine("Used memory:               " + Core.MemoryManager.GetUsedMemory() + "MB");
                    Console.WriteLine("Free memory:               " + Core.MemoryManager.GetFreeMemory() + "MB");
                    Console.WriteLine("Processor(s):              " + CPU.GetCPUBrandString());
                    Console.WriteLine("Console mode:              " + Kernel.AConsole.Name);
                    break;

                case "nl_NL":
                    Console.WriteLine("Naam computer:             " + Kernel.ComputerName);
                    Console.WriteLine("Naam besturingssysteem:    Aura");
                    Console.WriteLine("Versie besturingssysteem:  " + Kernel.version);
                    Console.WriteLine("Revisie besturingssysteem: " + Kernel.revision);
                    Console.WriteLine("Datum en tijd:             " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Installeer datum:          " + config.GetValue("setuptime"));
                    }
                    Console.WriteLine("Starttijd van het systeem: " + Kernel.boottime);
                    Console.WriteLine("Totaal geheugen:           " + Core.MemoryManager.TotalMemory + "MB");
                    Console.WriteLine("Gebruikt geheugen:         " + Core.MemoryManager.GetUsedMemory() + "MB");
                    Console.WriteLine("Gratis geheugen:           " + Core.MemoryManager.GetFreeMemory() + "MB");
                    Console.WriteLine("Processor(s):              " + CPU.GetCPUBrandString());
                    Console.WriteLine("Consolewijze:              " + Kernel.AConsole.Name);
                    break;

                case "it_IT":
                    Console.WriteLine("Nome del computer:               " + Kernel.ComputerName);
                    Console.WriteLine("Nome del sistema operativo:      Aura");
                    Console.WriteLine("Versione del sistema operativo:  " + Kernel.version);
                    Console.WriteLine("Revisione del sistema operativo: " + Kernel.revision);
                    Console.WriteLine("Data e ora:                      " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Data Installazione Sistema:      " + config.GetValue("setuptime"));
                    }
                    Console.WriteLine("System Boot Time:                " + Kernel.boottime);
                    Console.WriteLine("Memoria totale:                  " + Core.MemoryManager.TotalMemory + "MB");
                    Console.WriteLine("Memoria utilizzata:              " + Core.MemoryManager.GetUsedMemory() + "MB");
                    Console.WriteLine("Memoria libera:                  " + Core.MemoryManager.GetFreeMemory() + "MB");
                    Console.WriteLine("Processor(s):                    " + CPU.GetCPUBrandString());
                    Console.WriteLine("Modalità console:                " + Kernel.AConsole.Name);
                    break;
                
                case "pl_PL":
                    Console.WriteLine("Nazwa Komputera:           " + Kernel.ComputerName);
                    Console.WriteLine("Nazwa systemu opr.:         Aura");
                    Console.WriteLine("Wersja systemu opr.:       " + Kernel.version);
                    Console.WriteLine("Podwersja systemu opr.:    " + Kernel.revision);
                    Console.WriteLine("Data i godzina:            " + Time.MonthString() + "/" + Time.DayString() + "/" + Time.YearString() + ", " + Time.TimeString(true, true, true));
                    if (Kernel.SystemExists)
                    {
                        Console.WriteLine("Data instalacji:       " + config.GetValue("setuptime"));
                    }
                    Console.WriteLine("Czas od startu:            " + Kernel.boottime);
                    Console.WriteLine("Pamiec RAM:                " + Core.MemoryManager.TotalMemory + "MB");
                    Console.WriteLine("RAM w uzyciu:              " + Core.MemoryManager.GetUsedMemory() + "MB");
                    Console.WriteLine("Wolny RAM:                 " + Core.MemoryManager.GetFreeMemory() + "MB");
                    Console.WriteLine("Procesor(y):               " + CPU.GetCPUBrandString());
                    Console.WriteLine("Tryb konsoli:              " + Kernel.AConsole.Name);
                    break;
            }
        }

        /// <summary>
        /// Display informations about Aura OS
        /// </summary>
        public static void About()
        {
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine("À Propos d'Aura OS:");
                    Console.WriteLine("Aura Team créé par Valentin CHARBONNIER et Alexy DA CRUZ.");
                    Console.WriteLine();
                    Console.WriteLine("Contributeurs:");
                    Console.WriteLine("- djlw78");
                    Console.WriteLine("- Og-Rok");
                    Console.WriteLine();
                    Console.WriteLine("Merci aussi aux contributeurs de Cosmos.");
                    Console.WriteLine("https://github.com/aura-systems/Aura-Operating-System");
                    break;

                case "en_US":
                    Console.WriteLine("About Aura OS:");
                    Console.WriteLine("Aura Team created by Valentin CHARBONNIER and Alexy DA CRUZ.");
                    Console.WriteLine();
                    Console.WriteLine("Contributors:");
                    Console.WriteLine("- djlw78");
                    Console.WriteLine("- Og-Rok");
                    Console.WriteLine();
                    Console.WriteLine("Thanks also to the Cosmos contributors.");
                    Console.WriteLine("https://github.com/aura-systems/Aura-Operating-System");
                    break;

                case "nl_NL":
                    Console.WriteLine("Over Aura OS:");
                    Console.WriteLine("Aura Team opgericht door Valentin CHARBONNIER en Alexy DA CRUZ.");
                    Console.WriteLine();
                    Console.WriteLine("Bijdragers:");
                    Console.WriteLine("- djlw78");
                    Console.WriteLine("- Og-Rok");
                    Console.WriteLine();
                    Console.WriteLine("Dank ook aan de Cosmos donateurs.");
                    Console.WriteLine("https://github.com/aura-systems/Aura-Operating-System");
                    break;

                case "it_IT":
                    Console.WriteLine("Informazioni su Aura OS:");
                    Console.WriteLine("Aura Team creato da Valentin CHARBONNIER e Alexy DA CRUZ.");
                    Console.WriteLine();
                    Console.WriteLine("Collaboratori:");
                    Console.WriteLine("- djlw78");
                    Console.WriteLine("- Og-Rok");
                    Console.WriteLine();
                    Console.WriteLine("Grazie anche ai collaboratori di Cosmos.");
                    Console.WriteLine("https://github.com/aura-systems/Aura-Operating-System");
                    break;
                    
                case "pl_PL":
                    Console.WriteLine("O Aura OS:");
                    Console.WriteLine("Aura Team stworzony przez Valentin CHARBONNIER i Alexy DA CRUZ.");
                    Console.WriteLine();
                    Console.WriteLine("Wspoltworcy:");
                    Console.WriteLine("- djlw78");
                    Console.WriteLine("- Og-Rok");
                    Console.WriteLine("Tlumaczenie: KaliMasterDev");
                    Console.WriteLine();
                    Console.WriteLine("Dziekujemy rowniez wspierajacym AuraOS.");
                    Console.WriteLine("https://github.com/aura-systems/Aura-Operating-System");
                    break;

            }
        }

    }
}
