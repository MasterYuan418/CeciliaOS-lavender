﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Welcome Message
* PROGRAMMERS:      Alexy DA CRUZ <dacruzalexy@gmail.com>
*                   Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using System;

namespace Aura_OS.System
{
    class WelcomeMessage
    {

        /// <summary>
        /// Display the welcome message
        /// </summary>
        public static void Display()
        {
            Logo.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            switch (Kernel.langSelected)
            {
                case "fr_FR":
                    Console.WriteLine(" * Documentation: aura-team.com");
                    break;

                case "en_US":
                    Console.WriteLine(" * Copyright (c) RisConn Studio");
                    Console.WriteLine(" * Cecilia OS is based on Aura OS");
                    Console.WriteLine(" * Version: " + Kernel.version);
                    break;

                case "nl_NL":
                    Console.WriteLine(" * Documentatie: aura-team.com");
                    break;

                case "it_IT":
                    Console.WriteLine(" * Documentazione: aura-team.com");
                    break;
                
                case "pl_PL":
                    Console.WriteLine(" * Dokumentacja: aura-team.com");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
        }

    }
}
