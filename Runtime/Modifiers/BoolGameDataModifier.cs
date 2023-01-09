using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/bool Modifier")]
    public class BoolGameDataModifier : GameDataModifier<bool>
    {
        public bool newValue;
    }
}
