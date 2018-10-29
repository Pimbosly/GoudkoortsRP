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

public class Ship : Moveable
{
    private static int maxcargo = 8;
	public int Cargo
	{
		get;
		set;
	}

    public Ship()
    {
        Cargo = 0;
        isFull = false;
    }
    public bool AddCargo()
    {
        if(!isFull)
        {
            Cargo++;
            if(Cargo == maxcargo)
            {
                isFull = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

	public override void Empty()
	{
        if (Cargo != 0)
        {
            Cargo = 0;
            isFull = false;
        }
	}

    public override char Icon()
    {
        switch (Cargo)
        {
            case 0:
                return '7';
            case 1:
                return '6';
            case 2:
                return '6';
            case 3:
                return '4';
            case 4:
                return '4';
            case 5:
                return '2';
            case 6:
                return '2';
            case 7:
                return '1';
            case 8:
                return '8';
            default:
                return '!';
        }

    }
    public void printResults ()
    {
        if (true)
        {
            printResults();
        }
        else
        {
            throw new System.Exception();
        }
   
    }
    public override bool Move()
	{
        if(!isFull)
        {
            return true;
        }
        else
        {
            return Position.TryMove(this);
        }
	}

}

