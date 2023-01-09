using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowdrama.GameData
{
    [System.Serializable]
    public class GameData
    {
        //TODO: Come back and add a bunch of hashing stuff for the Dictionary<int, int>
        public StringIntDictionary intFlags = new StringIntDictionary();
        public StringStringDictionary stringFlags = new StringStringDictionary();
        //public StringActionDictionary intActionFlags = new StringActionDictionary<int>();
        public StringFloatDictionary floatFlags = new StringFloatDictionary();
        public StringBoolDictionary boolFlags = new StringBoolDictionary();
        public StringVector2Dictionary vector2Flags = new StringVector2Dictionary();
        public StringVector3Dictionary vector3Flags = new StringVector3Dictionary();
        public StringVector2IntDictionary vector2IntFlags = new StringVector2IntDictionary();
        public StringVector3IntDictionary vector3IntFlags = new StringVector3IntDictionary();
        public StringColorDictionary colorFlags = new StringColorDictionary();
        public void Init()
        {
            intFlags = new StringIntDictionary();
            stringFlags = new StringStringDictionary();
            floatFlags = new StringFloatDictionary();
            boolFlags = new StringBoolDictionary();
            vector2Flags = new StringVector2Dictionary();
            vector3Flags = new StringVector3Dictionary();
            vector2IntFlags = new StringVector2IntDictionary();
            vector3IntFlags = new StringVector3IntDictionary();
            colorFlags = new StringColorDictionary();
        }

        public void ClearAllData()
        {
            intFlags.Clear();
            stringFlags.Clear();
            floatFlags.Clear();
            boolFlags.Clear();
            vector2Flags.Clear();
            vector3Flags.Clear();
            colorFlags.Clear();
        }

        #region Ints
        public bool RawTryGetFlagInt(string key, out int output)
        {
            var convertedKey = key;
            if (intFlags.ContainsKey(convertedKey))
            {
                output = intFlags[convertedKey];
                return true;
            }
            output = 0;
            return false;
        }
        public int RawGetFlagInt(string key, int fallbackState = 0)
        {
            var convertedKey = key;
            return intFlags.ContainsKey(convertedKey) ? intFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagInt(string key, int state)
        {
            var convertedKey = key;
            if (intFlags.ContainsKey(convertedKey))
            {
                intFlags[convertedKey] = state;
            }
            else
            {
                intFlags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public int GetFlagInt(GameDataKey<int> gameDataKey, int fallbackState = 0)
        {
            return RawGetFlagInt(gameDataKey.KeyName);
        }

        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagInt(GameDataKey<int> gameDataKey, int value)
        {
            RawSetFlagInt(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }

        public void ModifyFlagInt(IntGameDataModifier modifier)
        {
            var value = RawGetFlagInt(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case IntGameDataModifier.IntGameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case IntGameDataModifier.IntGameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case IntGameDataModifier.IntGameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagInt(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }

        #endregion


        #region Strings
        public bool RawTryGetFlagString(string key, out string output)
        {
            var convertedKey = key;
            if (stringFlags.ContainsKey(convertedKey))
            {
                output = stringFlags[convertedKey];
                return true;
            }
            output = null;
            return false;
        }
        public string RawGetFlagString(string key, string fallbackState = null)
        {
            var convertedKey = key;
            return stringFlags.ContainsKey(convertedKey) ? stringFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagString(string key, string state)
        {
            var convertedKey = key;
            if (stringFlags.ContainsKey(convertedKey))
            {
                stringFlags[convertedKey] = state;
            }
            else
            {
                stringFlags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public string GetFlagString(GameDataKey<string> gameDataKey, string fallbackState = null)
        {
            return RawGetFlagString(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagString(GameDataKey<string> gameDataKey, string value)
        {
            RawSetFlagString(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }

        public void ModifyFlagString(StringGameDataModifier modifier)
        {
            RawSetFlagString(modifier.gameDataKey.KeyName, modifier.newValue);
            modifier.gameDataKey.onChange?.Invoke(modifier.newValue);
        }
        #endregion

        #region Floats
        public bool RawTryGetFlagFloat(string key, out float output)
        {
            var convertedKey = key;
            if (floatFlags.ContainsKey(convertedKey))
            {
                output = floatFlags[convertedKey];
                return true;
            }
            output = 0;
            return false;
        }
        public void RawSetFlagFloat(string key, float state)
        {
            var convertedKey = key;
            if (floatFlags.ContainsKey(convertedKey))
            {
                floatFlags[convertedKey] = state;
            }
            else
            {
                floatFlags.Add(convertedKey, state);
            }
        }
        public float RawGetFlagFloat(string key, float fallbackState = 0.0f)
        {
            var convertedKey = key;
            if (floatFlags.ContainsKey(convertedKey))
            {
                return intFlags[convertedKey];
            }
            return fallbackState;
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public float GetFlagFloat(GameDataKey<float> gameDataKey)
        {
            return RawGetFlagFloat(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagFloat(GameDataKey<float> gameDataKey, float value)
        {
            RawSetFlagFloat(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagFloat(FloatGameDataModifier modifier)
        {
            var value = RawGetFlagFloat(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case FloatGameDataModifier.FloatGameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case FloatGameDataModifier.FloatGameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case FloatGameDataModifier.FloatGameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagFloat(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }

        #endregion

        #region Bools
        public bool RawTryGetFlagBool(string key, out bool output)
        {
            var convertedKey = key;
            if (boolFlags.ContainsKey(convertedKey))
            {
                output = boolFlags[convertedKey];
                return true;
            }
            output = false;
            return false;
        }
        public bool RawGetFlagBool(string key, bool fallbackState = false)
        {
            var convertedKey = key;
            return boolFlags.ContainsKey(convertedKey) ? boolFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagBool(string key, bool state)
        {
            var convertedKey = key;
            if (boolFlags.ContainsKey(convertedKey))
            {
                boolFlags[convertedKey] = state;
            }
            else
            {
                boolFlags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public bool GetFlagBool(GameDataKey<bool> gameDataKey)
        {
            return RawGetFlagBool(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagBool(GameDataKey<bool> gameDataKey, bool value)
        {
            RawSetFlagBool(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }

        public void ModifyFlagBool(BoolGameDataModifier modifier)
        {
            RawSetFlagBool(modifier.gameDataKey.KeyName, modifier.newValue);
            modifier.gameDataKey.onChange?.Invoke(modifier.newValue);
        }

        #endregion

        #region Vector2
        public bool RawTryGetFlagVector2(string key, out Vector2 output)
        {
            var convertedKey = key;
            if (vector2Flags.ContainsKey(convertedKey))
            {
                output = vector2Flags[convertedKey];
                return true;
            }
            output = new Vector2();
            return false;
        }
        public Vector2 RawGetFlagVector2(string key, Vector2 fallbackState = default)
        {
            var convertedKey = key;
            return vector2Flags.ContainsKey(convertedKey) ? vector2Flags[convertedKey] : fallbackState;
        }
        public void RawSetFlagVector2(string key, Vector2 state)
        {
            var convertedKey = key;
            if (vector2Flags.ContainsKey(convertedKey))
            {
                vector2Flags[convertedKey] = state;
            }
            else
            {
                vector2Flags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public Vector2 GetFlagVector2(GameDataKey<Vector2> gameDataKey)
        {
            return RawGetFlagVector2(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagVector2(GameDataKey<Vector2> gameDataKey, Vector2 value)
        {
            RawSetFlagVector2(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagVector2(Vector2GameDataModifier modifier)
        {
            var value = RawGetFlagVector2(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case Vector2GameDataModifier.Vector2GameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case Vector2GameDataModifier.Vector2GameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case Vector2GameDataModifier.Vector2GameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagVector2(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }
        #endregion

        #region Vector3
        public bool RawTryGetFlagVector3(string key, out Vector3 output)
        {
            var convertedKey = key;
            if (vector3Flags.ContainsKey(convertedKey))
            {
                output = vector3Flags[convertedKey];
                return true;
            }
            output = new Vector3();
            return false;
        }
        public Vector3 RawGetFlagVector3(string key, Vector3 fallbackState = default)
        {
            var convertedKey = key;
            return vector3Flags.ContainsKey(convertedKey) ? vector3Flags[convertedKey] : fallbackState;
        }
        public void RawSetFlagVector3(string key, Vector3 state)
        {
            var convertedKey = key;
            if (vector3Flags.ContainsKey(convertedKey))
            {
                vector3Flags[convertedKey] = state;
            }
            else
            {
                vector3Flags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public Vector3 GetFlagVector3(GameDataKey<Vector3> gameDataKey)
        {
            return RawGetFlagVector3(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagVector3(GameDataKey<Vector3> gameDataKey, Vector3 value)
        {
            RawSetFlagVector3(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagVector3(Vector3GameDataModifier modifier)
        {
            var value = RawGetFlagVector3(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case Vector3GameDataModifier.Vector3GameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case Vector3GameDataModifier.Vector3GameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case Vector3GameDataModifier.Vector3GameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagVector3(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }
        #endregion

        #region Vector2Int
        public bool RawTryGetFlagVector2Int(string key, out Vector2Int output)
        {
            var convertedKey = key;
            if (vector2Flags.ContainsKey(convertedKey))
            {
                output = vector2IntFlags[convertedKey];
                return true;
            }
            output = new Vector2Int();
            return false;
        }
        public Vector2Int RawGetFlagVector2Int(string key, Vector2Int fallbackState = default)
        {
            var convertedKey = key;
            return vector2IntFlags.ContainsKey(convertedKey) ? vector2IntFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagVector2Int(string key, Vector2Int state)
        {
            var convertedKey = key;
            if (vector2IntFlags.ContainsKey(convertedKey))
            {
                vector2IntFlags[convertedKey] = state;
            }
            else
            {
                vector2IntFlags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public Vector2Int GetFlagVector2Int(GameDataKey<Vector2Int> gameDataKey)
        {
            return RawGetFlagVector2Int(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagVector2Int(GameDataKey<Vector2Int> gameDataKey, Vector2Int value)
        {
            RawSetFlagVector2Int(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagVector2Int(Vector2IntGameDataModifier modifier)
        {
            var value = RawGetFlagVector2Int(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case Vector2IntGameDataModifier.Vector2IntGameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case Vector2IntGameDataModifier.Vector2IntGameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case Vector2IntGameDataModifier.Vector2IntGameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagVector2Int(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }
        #endregion

        #region Vector3Int
        public bool RawTryGetFlagVector3Int(string key, out Vector3Int output)
        {
            var convertedKey = key;
            if (vector3Flags.ContainsKey(convertedKey))
            {
                output = vector3IntFlags[convertedKey];
                return true;
            }
            output = new Vector3Int();
            return false;
        }
        public Vector3Int RawGetFlagVector3Int(string key, Vector3Int fallbackState = default)
        {
            var convertedKey = key;
            return vector3IntFlags.ContainsKey(convertedKey) ? vector3IntFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagVector3Int(string key, Vector3Int state)
        {
            var convertedKey = key;
            if (vector3Flags.ContainsKey(convertedKey))
            {
                vector3Flags[convertedKey] = state;
            }
            else
            {
                vector3Flags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public Vector3Int GetFlagVector3Int(GameDataKey<Vector3Int> gameDataKey)
        {
            return RawGetFlagVector3Int(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagVector3Int(GameDataKey<Vector3Int> gameDataKey, Vector3Int value)
        {
            RawSetFlagVector3Int(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagVector3Int(Vector3IntGameDataModifier modifier)
        {
            var value = RawGetFlagVector3Int(modifier.gameDataKey.KeyName);
            switch (modifier.modifierType)
            {
                case Vector3IntGameDataModifier.Vector3IntGameDataModifierType.Add:
                    value += modifier.changeAmount;
                    break;
                case Vector3IntGameDataModifier.Vector3IntGameDataModifierType.Subtract:
                    value -= modifier.changeAmount;
                    break;
                case Vector3IntGameDataModifier.Vector3IntGameDataModifierType.Set:
                    value = modifier.changeAmount;
                    break;
            }
            RawSetFlagVector3Int(modifier.gameDataKey.KeyName, value);
            modifier.gameDataKey.onChange?.Invoke(value);
        }
        #endregion

        #region Colors
        public bool RawTryGetFlagColor(string key, out Color output)
        {
            var convertedKey = key;
            if (colorFlags.ContainsKey(convertedKey))
            {
                output = colorFlags[convertedKey];
                return true;
            }
            output = new Color();
            return false;
        }
        public Color RawGetFlagColor(string key, Color fallbackState = default)
        {
            var convertedKey = key;
            return colorFlags.ContainsKey(convertedKey) ? colorFlags[convertedKey] : fallbackState;
        }
        public void RawSetFlagColor(string key, Color state)
        {
            var convertedKey = key;
            if (colorFlags.ContainsKey(convertedKey))
            {
                colorFlags[convertedKey] = state;
            }
            else
            {
                colorFlags.Add(convertedKey, state);
            }
        }
        //uses a game key to get the value, PREFERED because the key SO can be shared and is read only
        public Color GetFlagColor(GameDataKey<Color> gameDataKey)
        {
            return RawGetFlagColor(gameDataKey.KeyName);
        }
        //uses a game key to set the value, PREFERED because the key SO can be shared and is read only
        public void SetFlagColor(GameDataKey<Color> gameDataKey, Color value)
        {
            RawSetFlagColor(gameDataKey.KeyName, value);
            gameDataKey.onChange?.Invoke(value);
        }
        public void ModifyFlagColor(ColorGameDataModifier modifier)
        {
            RawSetFlagColor(modifier.gameDataKey.KeyName, modifier.newValue);
            modifier.gameDataKey.onChange?.Invoke(modifier.newValue);
        }
        #endregion

        public void ApplyModifier<T>(GameDataModifier<T> modifier)
        {
            switch (modifier)
            {
                case IntGameDataModifier mod:
                    ModifyFlagInt(mod);
                    break;
                case StringGameDataModifier mod:
                    ModifyFlagString(mod);
                    break;
                case FloatGameDataModifier mod:
                    ModifyFlagFloat(mod);
                    break;
                case BoolGameDataModifier mod:
                    ModifyFlagBool(mod);
                    break;
                case Vector2GameDataModifier mod:
                    ModifyFlagVector2(mod);
                    break;
                case Vector3GameDataModifier mod:
                    ModifyFlagVector3(mod);
                    break;
                case Vector3IntGameDataModifier mod:
                    ModifyFlagVector3Int(mod);
                    break;
                case Vector2IntGameDataModifier mod:
                    ModifyFlagVector2Int(mod);
                    break;
                case ColorGameDataModifier mod:
                    ModifyFlagColor(mod);
                    break;
            }
        }
    }
}