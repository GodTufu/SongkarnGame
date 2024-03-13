using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text text;
    static private int value = 0;   
    static public void Add(int Num)
    {
        value += Num;
    }

    private void Update()
    {
        text.text = "Score : " + value;
    }

    static public int Show()
    {
        return value;
    }
}
