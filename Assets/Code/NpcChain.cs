using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcChain : MonoBehaviour, IWater
{
    public GameObject Cscene;
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
            Switch = false;
            Cscene.SetActive(true);
            Character_Movement.con = false;
            Debug.Log("Hit");
            Npc2.Switch = true;
        }
        else
        {

        }
    }
}
