using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class IntGameDataModifier : GameDataModifier
    {
        public enum IntGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public IntGameDataModifierType modifierType;
        public int changeAmount;
    }
}
