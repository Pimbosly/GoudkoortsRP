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

public class Split : Switch
{
	public virtual Track tempNext
	{
		get;
		set;
	}

    public Split()
    {
        isOpen = true;
    }
    public override char Icon()
    {
        if(isOpen)
        {
            return '/';
        }
        else
        {
            return '\\';
        }
    }

    public override void swapNext()
    {
        Track tempNext2 = NextTrack;
        NextTrack = tempNext;
        tempNext = tempNext2;
    }
}

