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

    public Boolean gameOver = false;
    public int Score = 20;

   // public int Speed = 5000;
   public virtual Dock Sea
    {
        get;
        set;
    }
	public virtual List<Warehouse> Warehouse
	{
		get;
		set;
	}

	public virtual IEnumerable<Moveable> Moveable
	{
		get;
		set;
	}

	public virtual void addCart(Warehouse warehouse)
	{
        Cart k = new Cart();
        warehouse.Moveable.Add(k);
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
            return 5000 / Score * 9;
        }
        
    }

}

