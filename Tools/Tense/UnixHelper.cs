﻿using System;
using Birdhouse.Common.Extensions;
using Birdhouse.Tools.Tense.Controllers.Interfaces;
using Birdhouse.Tools.Tense.Timestamps;
using Birdhouse.Tools.Tense.Timestamps.Interfaces;

namespace Birdhouse.Tools.Tense
{
    public static class UnixHelper
    {
        public static readonly DateTime Origin = new DateTime(1970, 1, 1);

        public static long ToUnix(DateTime value)
        {
            return (long) (value - Origin).TotalSeconds;
        }

        public static DateTime FromUnix(long value)
        {
            return Origin.AddSeconds(value);
        }

        public static ITimestamp<TimeSpan> CreateDefaultUnixTimestamp()
        {
            var tenseController = TenseHelper.UtcNowTenseProvider.AsTimeSpanUnix();
            
            var result = new TimeSpanTimestamp(tenseController);
            return result;
        }
    }
}