﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

public class ShowHidePassEffect : RoutingEffect
{
    public string EntryText
    {
        get;
        set;
    }
    public ShowHidePassEffect() : base("Xamarin.ShowHidePassEffect") { }
}
