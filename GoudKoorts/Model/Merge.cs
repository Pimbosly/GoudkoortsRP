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

public class Merge : Switch
{
	public virtual Track tempPrevious
	{
		get;
		set;
	}

    public override char Icon()
    {
        if (Moveable.Count == 0)
        {
            if (isOpen)
            {
                return '\\';
            }
            else
            {
                return '/';
            }
        }
        else
        {
            return Moveable[0].Icon();
        }
    }

    public override void swapNext()
    {
        Track tempPrevious2 = NextTrack;
        PreviousTrack = tempPrevious;
        tempPrevious = tempPrevious2;
    }
}

