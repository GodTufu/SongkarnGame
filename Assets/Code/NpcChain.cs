using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcChain : MonoBehaviour, IWater
{
    public NpcChain Npc2;
    public bool Switch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Splash()
    {
        if (Switch)
        {
            Debug.Log("Hit");
            Npc2.Switch = true;
        }
        else
        {

        }
    }
}
