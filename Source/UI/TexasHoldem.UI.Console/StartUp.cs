﻿namespace TexasHoldem.UI.Console
{
    using System;
    
    using TexasHoldem.AI.SmartPlayer;
    using TexasHoldem.Logic.GameMechanics;
    using TexasHoldem.AI.RaiseTwoSevenTestPlayer;
    using TexasHoldem.AI.DummyPlayer;
    public static class StartUp
    {
        private const string ProgramName = "TexasHoldem.UI.Console (c) 2015";
        private const int GameHeight = 33;
        private const int GameWidth = 88;

        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BufferHeight = Console.WindowHeight = GameHeight;
            Console.BufferWidth = Console.WindowWidth = GameWidth;

            ConsoleHelper.WriteOnConsole(GameHeight - 1, GameWidth - ProgramName.Length - 1, ProgramName, ConsoleColor.Green);

            //TODO our player here
            var raiseTwoSevenTestPlayer = new ConsoleUiDecorator(new RaiseTwoSevenPlayer(), 0, GameWidth, 5);
            var consolePlayer2 = new ConsoleUiDecorator(new SmartPlayer(), 6, GameWidth, 5);
            ITexasHoldemGame game = new TwoPlayersTexasHoldemGame(raiseTwoSevenTestPlayer, consolePlayer2);
            game.Start();
        }
    }
}