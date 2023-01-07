using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class Vector3GameDataModifier : GameDataModifier
    {
        public enum Vector3GameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector3GameDataModifierType modifierType;
        public Vector3 changeAmount;
    }
}
