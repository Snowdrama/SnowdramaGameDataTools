using System;
using UnityEngine;

namespace Snowdrama.GameData
{
    public class Vector2GameDataKey : GameDataKey
    {
        public Action<Vector2> onChange;
    }
}