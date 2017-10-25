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
    public int Score = 0;

	public virtual IEnumerable<Warehouse> Warehouse
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
		throw new System.NotImplementedException();
	}

	public virtual void delCart(Cart cart)
	{
		throw new System.NotImplementedException();
	}

	public virtual Warehouse randomWarehouse()
	{
		throw new System.NotImplementedException();
	}

    public virtual void play()
    {
        while(!gameOver)
        {
            foreach(Moveable m in Moveable)
            {
                m.Move();
            }
            System.Threading.Thread.Sleep(1000);
        }
    }

}

