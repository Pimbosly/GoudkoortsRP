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

public class Warehouse : Track
{
    public override char Icon()
    {
        if (Moveable.Count == 0)
        {
            return 'K';
        }
        else
        {
            return Moveable[0].Icon();
        }
    }
}

