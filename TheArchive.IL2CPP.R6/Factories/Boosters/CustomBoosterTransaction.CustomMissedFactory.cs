﻿using DropServer.BoosterImplants;
using System;
using TheArchive.Interfaces;
using static TheArchive.Loader.LoaderWrapper;
using static TheArchive.Models.Boosters.LocalBoosterTransaction;

namespace TheArchive.IL2CPP.R6.Factories
{
    public class CustomMissedFactory : IBaseGameConverter<CustomMissed>
    {
        public CustomMissed FromBaseGame(object baseGame, CustomMissed existingCM = null)
        {
            var baseGameMissed = (BoosterImplantTransaction.Missed) baseGame;

            var customMissed = existingCM ?? new CustomMissed();

            customMissed.Basic = baseGameMissed.Basic;
            customMissed.Advanced = baseGameMissed.Advanced;
            customMissed.Specialized = baseGameMissed.Specialized;

            return customMissed;
        }

        public Type GetBaseGameType() => typeof(BoosterImplantTransaction.Missed);

        public Type GetCustomType() => typeof(CustomMissed);

        public object ToBaseGame(CustomMissed customMissed, object existingBaseGame = null)
        {
            var baseGameMissed = (BoosterImplantTransaction.Missed) existingBaseGame ?? new BoosterImplantTransaction.Missed(ClassInjector.DerivedConstructorPointer<BoosterImplantTransaction.Missed>());

            baseGameMissed.Basic = customMissed.Basic;
            baseGameMissed.Advanced = customMissed.Advanced;
            baseGameMissed.Specialized = customMissed.Specialized;

            return baseGameMissed;
        }
    }
}
