using System;

namespace Snowdrama.GameData
{
    public class IntGameDataKey : GameDataKey
    {
        public Action<int> onChange;
    }
}