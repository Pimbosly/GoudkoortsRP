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
	public int Cargo
	{
		get;
		set;
	}

    public bool isDocked
    {
        get;
        set;
    }

    public Ship()
    {
        Cargo = 0;
        isDocked = true;
        isFull = false;
    }
    public bool AddCargo()
    {
        if(Cargo < 8)
        {
            Cargo++;
            if(Cargo == 8)
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
                return '8';
            case 1:
                return '7';
            case 2:
                return '6';
            case 3:
                return '5';
            case 4:
                return '4';
            case 5:
                return '3';
            case 6:
                return '2';
            case 7:
                return '1';
            case 8:
                return '0';
            default:
                return '?';
        }

    }

    public override void Move()
	{

        Position.TryMove(this);
	}

}

