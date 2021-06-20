using UnityEngine;

[System.Serializable]
public class AdvancedKeyCode
{
    public KeyCode[] keys;
    bool used;

    public AdvancedKeyCode(params KeyCode[] keys)
    {
        this.keys = keys;
    }

    public bool GetKey()
    {
        foreach (KeyCode key in keys)
            if (!Input.GetKey(key))
                return false;

        return true;
    }

    public bool GetKeyDown()
    {
        if (used)
        {
            if (!GetKey())
                used = false;
            return false;
        }

        return used = GetKey();
    }

    public bool GetKeyUp()
    {
        if (!used)
            return false;

        if (!GetKey())
            return true;

        return false;
    }

    public static implicit operator AdvancedKeyCode(KeyCode keyCode)
    {
        return new AdvancedKeyCode(keyCode);
    }

    public static implicit operator AdvancedKeyCode(KeyCode[] keyCodes)
    {
        return new AdvancedKeyCode(keyCodes);
    }
}
