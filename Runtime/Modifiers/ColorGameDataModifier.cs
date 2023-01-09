using UnityEngine;
namespace Snowdrama.GameData
{
    [CreateAssetMenu(menuName = "Snowdrama/GameData/Modifiers/Color Modifier")]
    public class ColorGameDataModifier : GameDataModifier<Color>
    {
        public Color newValue;
    }
}
