﻿using Birdhouse.Tools.Data.Transmission.Adapters;
using Birdhouse.Tools.Data.Transmission.Interfaces;
using Birdhouse.Tools.Serialization.Interfaces;

namespace Birdhouse.Tools.Data.Transmission
{
    public static class DataTransmissionExtensions
    {
        public static IDataTransmitter<T> Sync<T>(this IAsyncDataTransmitter<T> self)
        {
            var result = new AsyncDataTransmitterToSyncAdapter<T>(self);
            return result;
        }

        public static IPersistentDataService<TKey> AsPersistentDataService<TKey>(this ISerializationStorage<TKey> self)
        {
            var result = new StoragePersistentDataService<TKey>(self);
            return result;
        }
    }
}