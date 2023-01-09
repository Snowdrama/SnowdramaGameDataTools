using System;
using UnityEngine;

namespace Snowdrama.GameData
{
    public class Vector3IntGameDataKey : GameDataKey
    {
        public Action<Vector3Int> onChange;
    }
}