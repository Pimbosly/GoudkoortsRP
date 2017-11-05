﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using GoudKoorts.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{

    Parser parser;
    Output output = new Output();
    Input input = new Input();
    System.Threading.Thread A;

    Game g;

    public GameController()
    {
        g = new Game();
        loadMainMenu();
        
    }
    public virtual Game Game
	{
		get;
		set;
	}

	public virtual Output Output
	{
		get;
		set;
	}

	public virtual Input Input
	{
		get;
		set;
	}

	public virtual void loadMainMenu()
	{
        Boolean mainMenu = true;
        if (g.gameOver == true)
        {
            g.gameOver = false;
        }
        output.printMain();
        
        while (mainMenu)
        {
            Console.WriteLine("Press any key to continue");
            ConsoleKeyInfo cki = input.askInputKey();
            if (cki.KeyChar == cki.KeyChar)
            {
                    parser = new Parser();
                    mainMenu = false;
                    StartGame();
            }
        }

    }
    public virtual void StartGame()
    {

        A = new System.Threading.Thread(new
        System.Threading.ThreadStart(Play));

        A.Start();
        if (g.gameOver == true)
        {
            g.gameOver = false;
        }
        while (!g.gameOver)
        {
            handleInput(input.askInputKey().Key);
        }

        if (A.IsAlive)
        {
            A.Abort();
        }



    }

    public void Play()
    {
        
            while (!g.gameOver)
            {
                printBoard();
                A.Join(g.Speed());
                
                if (g.Moveable != null)
                {
                    if (g.Moveable.Count() != 0)
                    {
                        
                        foreach (Moveable m in g.Moveable)
                        {
                            m.Move();
                            if (m.Position == g._track[9, 1])
                            {
                                g.atDock(m);
                            }
                        }
                    }
                }
            }

        Quit();

            
            


    }
    public void handleInput(ConsoleKey input)
    {
        if (!g.gameOver)
        {
            Switch s;
            switch (input)
            {
                case ConsoleKey.NumPad4:
                    s = (Switch)g._track[3, 4];
                    s.Swap();
                    break;
                case ConsoleKey.NumPad5:
                    s = (Switch)g._track[5, 4];
                    s.Swap();
                    break;
                case ConsoleKey.NumPad6:
                    s = (Switch)g._track[9, 4];
                    s.Swap();
                    break;
                case ConsoleKey.NumPad2:
                    s = (Switch)g._track[6, 6];
                    s.Swap();
                    break;
                case ConsoleKey.NumPad3:
                    s = (Switch)g._track[8, 6];
                    s.Swap();
                    break;
                case ConsoleKey.Q:
                    g.gameOver = true;
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            printBoard();
        }
    }

    public void gameOver()
    {
        output.printEnd();

    }
    public void Quit()
    {
        output.printEnd();
        Console.WriteLine("Your score is: " + g.Score);
        Console.WriteLine("");
        Console.WriteLine("Press any key to continu");
        ConsoleKeyInfo cki = input.askInputKey();
        g = new Game();
        loadMainMenu();


    }

    public void printBoard()
    {
        output.printLevel();
        Console.WriteLine("Your score = " + g.Score);
        Console.WriteLine(g.Speed() / 100);
        Console.WriteLine("");
        string s = "";
        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 12; x++)
            {
                if (g._track[x, y] != null)
                {
                    s = s + g._track[x, y].Icon();
                }
                else
                {
                    s = s + " ";
                }
                
            }
            Console.WriteLine(s);
            s = "";
        }
        
    }

}

