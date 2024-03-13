using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsceneOnOff : MonoBehaviour
{
    public GameObject Self;

    public void On()
    {
        Self.SetActive(true);
    }

    public void Off()
    {
        Self.SetActive(false);
        Character_Movement.con = true;
    }
}
