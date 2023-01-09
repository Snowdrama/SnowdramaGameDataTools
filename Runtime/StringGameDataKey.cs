using System;

namespace Snowdrama.GameData
{
    public class StringGameDataKey : GameDataKey
    {
        public Action<string> onChange;
    }
}