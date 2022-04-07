﻿using System;
using ESparrow.Utils.Tools.Easing.Interfaces;

namespace ESparrow.Utils.Tools.Graduating.Interfaces
{
    public interface IGradualSettings : ITweeningSettings
    {
        Action<float> Action
        {
            get;
        }
    }
}
