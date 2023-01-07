using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class Vector2GameDataModifier : GameDataModifier
    {
        public enum Vector2GameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public Vector2GameDataModifierType modifierType;
        public Vector2 changeAmount;
    }
}
