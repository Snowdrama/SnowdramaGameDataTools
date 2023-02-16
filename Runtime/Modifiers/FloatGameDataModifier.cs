using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/float Modifier")]
    public class FloatGameDataModifier : GameDataModifier<float>
    {
        public GameDataModifierType modifierType;
        public int changeAmount;
    }
}
