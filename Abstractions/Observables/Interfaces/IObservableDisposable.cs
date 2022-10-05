﻿using System;

namespace Birdhouse.Abstractions.Observables.Interfaces
{
    public interface IObservableDisposable : IDisposable
    {
        event Action OnDispose;
    }
}