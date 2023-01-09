using System;
using UnityEngine;

namespace Snowdrama.GameData
{
    public class ColorIntGameDataKey : GameDataKey
    {
        public Action<Color> onChange;
    }
}