﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{
    Output output = new Output();
    Input input = new Input();
    System.Threading.Thread A;
    int _carcount;
    Game g;

    public GameController()
    {
        _carcount = 4;
        A = new System.Threading.Thread(new
        System.Threading.ThreadStart(Play));
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
                    mainMenu = false;
                    StartGame();
            }
        }

    }
    public virtual void StartGame()
    {
        if(!A.IsAlive)
        {
            A = new System.Threading.Thread(new
        System.Threading.ThreadStart(Play));
            A.Start();
        }

        if (g.gameOver == true)
        {
            g.gameOver = false;
        }
        
        while (!g.gameOver)
        {
            handleInput(input.askInputKey().Key);
        }
        Quit();
    }

    public void Play()
    {
        int turncount = 4;
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
                        if (!m.Move())
                        {
                            g.moveCart(g.randomWarehouse(), (Cart)m);
                        }
                        if (m.Position == g._track[9, 1])
                        {
                            g.atDock(m);
                        }  
                        if (m.Position == g._track[9,0])
                        {
                            if (g.ship.isFull)
                            {
                                g.ship.Empty();
                                _carcount++;
                            }
                        }                     
                    }
                    turncount--;
                    if (turncount == 0)
                    {
                        if(_carcount > g.Moveable.Count)
                        {
                            g.addCart(g.randomWarehouse());
                        }
                        turncount = 4;
                    }
                    if (g.CollisionCheck())
                    {
                        g.gameOver = true;
                    }
                }
            }
        }
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
                    break;
                default:
                    break;
            }

            printBoard();
        }
    }


    public void Quit()
    {
        output.printEnd();
        Console.WriteLine("Your score is: " + g.Score);
        Console.WriteLine("");
        Console.WriteLine("Press any key to continue");
        ConsoleKeyInfo cki = input.askInputKey();
        g = new Game();
        loadMainMenu();
    }

    public void printBoard()
    {
        output.printLevel();
        Console.WriteLine("Your score = " + g.Score);
        Console.WriteLine("Your speed in milliseconds = " + g.Speed() / 10);
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

