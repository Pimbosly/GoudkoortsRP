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

public class Cart : Moveable
{
	public virtual bool canMove
	{
		get;
		set;
	}

	public override void Empty()
	{
        if (isFull == true)
        {
            isFull = false;
        }
	}

    public override char Icon()
    {
        throw new NotImplementedException();
    }

    public override void Move()
	{
        Position.TryMove(this);
	}

}

