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

public abstract class Track
{
    public virtual bool IsTooMuch
    {
        get;
        set;
    }
	public virtual Char Icon
	{
		get;
		set;
	}

	public virtual List<Moveable> Moveable
	{
		get;
		set;
	}

	public virtual Track NextTrack
	{
		get;
		set;
	}

	public virtual Track PreviousTrack
	{
		get;
		set;
	}

	public virtual bool nextIsPrevious(Track track)
	{
		if(track.NextTrack.PreviousTrack == track)
        {
            return true;
        }
        else
        {
            return false;
        }
	}

    public virtual void CheckTooMuch()
    {
        if(Moveable.Count > 1)
        {
            IsTooMuch = true;
        }
        else
        {
            IsTooMuch = false;
        }
    }

	public virtual void TryMove(Moveable moveable)
	{
		if(nextIsPrevious(this))
        {
            NextTrack.Moveable.Add(moveable);
            NextTrack.CheckTooMuch();

            Moveable.Remove(moveable);
            CheckTooMuch();
        }
	}

}

