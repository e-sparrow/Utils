﻿using System;
using Birdhouse.Tools.Tense.Enums;

namespace Birdhouse.Tools.Tense.Expiration.Interfaces
{
    public interface ITermInfo
    {
        ETermType Type
        {
            get;
        }
        
        DateTime AbsoluteExpiration
        {
            get;
        }

        TimeSpan SlidingExpiration
        {
            get;
        }
    }
}