using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour ,IWater
{
    public GameObject InteracObj;
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
        Debug.Log("Hit");
    }

}
