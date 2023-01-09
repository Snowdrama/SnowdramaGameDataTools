using System;

namespace Snowdrama.GameData
{
    public class FloatGameDataKey : GameDataKey
    {
        public Action<float> onChange;
    }
}