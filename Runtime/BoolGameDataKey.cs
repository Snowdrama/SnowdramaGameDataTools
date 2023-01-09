using System;

namespace Snowdrama.GameData
{
    public class BoolGameDataKey : GameDataKey
    {
        public Action<bool> onChange;
    }
}