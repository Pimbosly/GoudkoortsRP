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

public class Dock : Track
{
    public Ship S
    {
        get;
        set;
    }
    public override int CollectPoints()
    {
        //return 10 at full ship
        //return 1 at 1 cart
        //TODO
        return 0;
    }

    public override char Icon()
    {
        if (Moveable.Count == 0)
        {
            return 'D';
        }
        else
        {
            return Moveable[0].Icon();
        }
    }

    public bool EmptyCart(Cart c)
    {
        if (S.isDocked)
        {
            c.Empty();
            S.AddCargo();
            return true;
        }

        return false;
    }


}

