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
	public virtual int Score
	{
		get;
		set;
	}

	public virtual bool gameOver
	{
		get;
		set;
	}

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

}

