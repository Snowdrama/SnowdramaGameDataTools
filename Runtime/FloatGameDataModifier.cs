using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu]
    public class FloatGameDataModifier : GameDataModifier
    {
        public enum FloatGameDataModifierType
        {
            Add = 0,
            Subtract = 1,
            Set = 2,
        }
        public FloatGameDataModifierType modifierType;
        public int changeAmount;
    }
}
