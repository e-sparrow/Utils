﻿using System;

namespace Birdhouse.Mechanics.Idle.Interfaces
{
    public interface IIdleController
    {
        void IdleFor(TimeSpan time);
    }
}