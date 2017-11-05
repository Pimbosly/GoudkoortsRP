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

public class Game
{
    Output output = new Output();
    Input input = new Input();
    public Ship ship;

    public Boolean gameOver;
    public int Score;

    
   // public int Speed = 5000;

	public virtual List<Warehouse> Warehouse
	{
		get;
		set;
	}

	public virtual List<Moveable> Moveable
	{
		get;
		set;
	}

    public Game()
    {
        Moveable = new List<Moveable>();
        _track = new Track[12, 10];
        Warehouse = new List<Warehouse>();
        gameOver = false;
        Score = 0;
        fillField();
    }

    public virtual Track[,] _track
    {
        get;
        set;
    }

	public virtual void addCart(Warehouse warehouse)
	{
        //Cart k = new Cart(warehouse);
        //warehouse.Moveable.Add(k);
        //Moveable.Add(k);
        Cart k = new Cart(Warehouse[0]);
        Warehouse[0].Moveable.Add(k);
        Moveable.Add(k);

        //Cart a = new Cart(Warehouse[1]);
        //Warehouse[1].Moveable.Add(a);
        //Moveable.Add(a);

        Cart b = new Cart(Warehouse[2]);
        Warehouse[2].Moveable.Add(b);
        Moveable.Add(b);
    }

    public virtual Warehouse randomWarehouse()
	{
        Random rnd = new Random();
        int nr = rnd.Next(0, 3);
        return Warehouse[nr];
	}

    public int Speed()
    {

        if (Score == 0)
        {
            return 5000;
        }
        else
        {
            return 5000 / (Score + 9) * 9;
        }
        
    }

    public bool CollisionCheck()
    {
        foreach(Moveable m in Moveable)
        {
            //points improvement
            Score = Score + m.Position.CollectPoints();
            if(m.Position.IsTooMuch)
            {
                //collision
                gameOver = true;
                return true;
            }
        }
        //no collision
        return false;
    }

    public void atDock(Moveable m)
    { 
        Cart c;

        c = (Cart)m;
        Dock d = (Dock)m.Position;

        if (d.EmptyCart(c))
        {
            Score++;
            if (ship.isFull)
            {
                Score = Score + 10;
            }
        }
            
    }
    public void fillField()
    {
        Switch c;

        _track[0, 1] = new NormalTrack();
        _track[1, 1] = new NormalTrack();
        _track[2, 1] = new NormalTrack();
        _track[3, 1] = new NormalTrack();
        _track[4, 1] = new NormalTrack();
        _track[5, 1] = new NormalTrack();
        _track[6, 1] = new NormalTrack();
        _track[7, 1] = new NormalTrack();
        _track[8, 1] = new NormalTrack();
        _track[9, 1] = new Dock();
        _track[10, 1] = new NormalTrack();
        _track[11, 1] = new NormalTrack();
        _track[11, 2] = new NormalTrack();
        _track[11, 3] = new NormalTrack();
        _track[11, 4] = new NormalTrack();
        _track[10, 4] = new NormalTrack();
        _track[9, 4] = new Merge();
        _track[9, 3] = new NormalTrack();
        _track[9, 5] = new NormalTrack();
        _track[8, 3] = new NormalTrack();
        _track[7, 3] = new NormalTrack();
        _track[6, 3] = new NormalTrack();
        _track[5, 3] = new NormalTrack();
        _track[5, 4] = new Split();
        _track[4, 4] = new NormalTrack();
        _track[3, 4] = new Merge();
        _track[3, 3] = new NormalTrack();
        _track[3, 5] = new NormalTrack();
        _track[2, 3] = new NormalTrack();
        _track[1, 3] = new NormalTrack();
        _track[2, 5] = new NormalTrack();
        _track[1, 5] = new NormalTrack();
        _track[1, 7] = new NormalTrack();
        _track[2, 7] = new NormalTrack();
        _track[3, 7] = new NormalTrack();
        _track[4, 7] = new NormalTrack();
        _track[5, 7] = new NormalTrack();
        _track[6, 7] = new NormalTrack();
        _track[6, 6] = new Merge();
        _track[6, 5] = new NormalTrack();
        _track[5, 5] = new NormalTrack();
        _track[7, 6] = new NormalTrack();
        _track[8, 6] = new Split();
        _track[8, 5] = new NormalTrack();
        _track[8, 7] = new NormalTrack();
        _track[9, 7] = new NormalTrack();
        _track[10, 7] = new NormalTrack();
        _track[11, 7] = new NormalTrack();
        _track[11, 8] = new NormalTrack();
        _track[10, 8] = new NormalTrack();
        _track[9, 8] = new NormalTrack();
        _track[8, 8] = new RangeArea();
        _track[7, 8] = new RangeArea();
        _track[6, 8] = new RangeArea();
        _track[5, 8] = new RangeArea();
        _track[4, 8] = new RangeArea();
        _track[3, 8] = new RangeArea();
        _track[2, 8] = new RangeArea();
        _track[1, 8] = new RangeArea();

        //warehouses
        _track[0, 3] = new Warehouse();
        _track[0, 5] = new Warehouse();
        _track[0, 7] = new Warehouse();

        Warehouse.Add((Warehouse)_track[0, 3]);
        Warehouse.Add((Warehouse)_track[0, 5]);
        Warehouse.Add((Warehouse)_track[0, 7]);

        //testKAR
        addCart(randomWarehouse());

        //water
        _track[0, 0] = new NormalTrack();
        _track[1, 0] = new NormalTrack();
        _track[2, 0] = new NormalTrack();
        _track[3, 0] = new NormalTrack();
        _track[4, 0] = new NormalTrack();
        _track[5, 0] = new NormalTrack();
        _track[6, 0] = new NormalTrack();
        _track[7, 0] = new NormalTrack();
        _track[8, 0] = new NormalTrack();
        _track[9, 0] = new NormalTrack();
        _track[10, 0] = new NormalTrack();
        _track[11, 0] = new NormalTrack();

        _track[9, 0].Moveable.Add(new Ship());
        Moveable.Add(_track[9, 0].Moveable[0]);
        Dock dock = (Dock)_track[9, 1];
        dock.S = (Ship)_track[9, 0].Moveable[0];

        NextTrack(Warehouse[2], _track[1, 7]);
        NextTrack(Warehouse[2], _track[2, 7]);
        NextTrack(Warehouse[2], _track[3, 7]);
        NextTrack(Warehouse[2], _track[4, 7]);
        NextTrack(Warehouse[2], _track[5, 7]);
        NextTrack(Warehouse[2], _track[6, 7]);
        NextTrack(Warehouse[2], _track[6, 6]);
        NextTrack(Warehouse[2], _track[7, 6]);
        NextTrack(Warehouse[2], _track[8, 6]);
        NextTrack(Warehouse[2], _track[8, 7]);
        NextTrack(Warehouse[2], _track[9, 7]);
        NextTrack(Warehouse[2], _track[10, 7]);
        NextTrack(Warehouse[2], _track[11, 7]);
        NextTrack(Warehouse[2], _track[11, 8]);
        NextTrack(Warehouse[2], _track[10, 8]);
        NextTrack(Warehouse[2], _track[9, 8]);
        NextTrack(Warehouse[2], _track[8, 8]);
        NextTrack(Warehouse[2], _track[7, 8]);
        NextTrack(Warehouse[2], _track[6, 8]);
        NextTrack(Warehouse[2], _track[5, 8]);
        NextTrack(Warehouse[2], _track[4, 8]);
        NextTrack(Warehouse[2], _track[3, 8]);
        NextTrack(Warehouse[2], _track[2, 8]);
        NextTrack(Warehouse[2], _track[1, 8]);

        c = (Switch)_track[6, 6];
        c.Swap();

        c = (Switch)_track[8, 6];
        c.Swap();

        NextTrack(Warehouse[1], _track[1, 5]);
        NextTrack(Warehouse[1], _track[2, 5]);
        NextTrack(Warehouse[1], _track[3, 5]);
        NextTrack(Warehouse[1], _track[3, 4]);
        NextTrack(Warehouse[1], _track[4, 4]);
        NextTrack(Warehouse[1], _track[5, 4]);
        NextTrack(Warehouse[1], _track[5, 5]);
        NextTrack(Warehouse[1], _track[6, 5]);
        NextTrack(Warehouse[1], _track[6, 6]);
        NextTrack(Warehouse[1], _track[8, 5]);
        NextTrack(Warehouse[1], _track[9, 5]);
        NextTrack(Warehouse[1], _track[9, 4]);
        NextTrack(Warehouse[1], _track[10, 4]);
        NextTrack(Warehouse[1], _track[11, 4]);
        NextTrack(Warehouse[1], _track[11, 3]);
        NextTrack(Warehouse[1], _track[11, 2]);
        NextTrack(Warehouse[1], _track[11, 1]);
        NextTrack(Warehouse[1], _track[10, 1]);
        NextTrack(Warehouse[1], _track[9, 1]);
        NextTrack(Warehouse[1], _track[8, 1]);
        NextTrack(Warehouse[1], _track[7, 1]);
        NextTrack(Warehouse[1], _track[6, 1]);
        NextTrack(Warehouse[1], _track[5, 1]);
        NextTrack(Warehouse[1], _track[4, 1]);
        NextTrack(Warehouse[1], _track[3, 1]);
        NextTrack(Warehouse[1], _track[2, 1]);
        NextTrack(Warehouse[1], _track[1, 1]);
        NextTrack(Warehouse[1], _track[0, 1]);

        c = (Switch)_track[3, 4];
        c.Swap();

        c = (Switch)_track[5, 4];
        c.Swap();

        c = (Switch)_track[9, 4];
        c.Swap();

        NextTrack(Warehouse[0], _track[1, 3]);
        NextTrack(Warehouse[0], _track[2, 3]);
        NextTrack(Warehouse[0], _track[3, 3]);
        NextTrack(Warehouse[0], _track[3, 4]);
        NextTrack(Warehouse[0], _track[5, 3]);
        NextTrack(Warehouse[0], _track[6, 3]);
        NextTrack(Warehouse[0], _track[7, 3]);
        NextTrack(Warehouse[0], _track[8, 3]);
        NextTrack(Warehouse[0], _track[9, 3]);
        NextTrack(Warehouse[0], _track[9, 4]);
    }

    public void NextTrack(Warehouse w, Track t)
    {
        Track T = w;
        while(T.NextTrack != null)
        {
            T = T.NextTrack;
        }
        T.NextTrack = t;
        t.PreviousTrack = T;
    }

}

