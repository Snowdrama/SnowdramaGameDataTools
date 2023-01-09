using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/float Modifier")]
    public class FloatGameDataModifier : GameDataModifier<float>
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
