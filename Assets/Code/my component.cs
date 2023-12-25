using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycomponent : MonoBehaviour
{
    [SerializeField] public static bool key9 = true;
    [SerializeField] public static bool key3 = false;
    [SerializeField] public static bool key4 = false;
    [SerializeField] public static bool key3_2 = false;
    [SerializeField] public static bool key_p = false;
    [SerializeField] public static bool statuette = true;
    [SerializeField] public static bool statuette_p = false;

    public void SetKey9(bool newKey9)
    {
        key9 = newKey9;
    }

    public void SetKey3(bool newKey3)
    {
        key3 = newKey3;
    }

    public void SetKey4(bool newKey4)
    {
        key4 = newKey4;
    }
    public void SetKey_p(bool newKey_p)
    {
        key_p = newKey_p;
    }
    public void SetStatuette(bool newStatuette)
    {
        statuette = newStatuette;
    }
    public void SetStatuette_p(bool newStatuette_p)
    {
        statuette_p = newStatuette_p;
    }
    public bool GetKey9()
    {
        return key9;
    }

    public bool GetKey3()
    {
        return key3;
    }

    public bool GetKey4()
    {
        return key4;
    }

    public bool GetKey3_2()
    {
        return key3_2;
    }
    public bool GetKey_p()
    {
        return key_p;
    }

    public bool GetStatuette()
    {
        return statuette;
    }
    public bool GetStatuette_p()
    {
        return statuette_p;
    }
}
