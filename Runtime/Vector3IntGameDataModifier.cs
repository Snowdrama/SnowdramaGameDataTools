using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class Vector3IntGameDataModifier : GameDataModifier
    {
        public enum Vector3IntGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector3IntGameDataModifierType modifierType;
        public Vector3Int changeAmount;
    }
}
