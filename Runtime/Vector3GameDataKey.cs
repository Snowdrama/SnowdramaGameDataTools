using System;
using UnityEngine;

namespace Snowdrama.GameData
{
    public class Vector3GameDataKey : GameDataKey
    {
        public Action<Vector3> onChange;
    }
}