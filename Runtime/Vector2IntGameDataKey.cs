using System;
using UnityEngine;

namespace Snowdrama.GameData
{
    public class Vector2IntGameDataKey : GameDataKey
    {
        public Action<Vector2Int> onChange;
    }
}