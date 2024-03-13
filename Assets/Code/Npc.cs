using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour ,IWater
{
    public GameObject Cscene;
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
        Cscene.SetActive(true);
        Character_Movement.con = false;
        Debug.Log("Hit");
    }

}
