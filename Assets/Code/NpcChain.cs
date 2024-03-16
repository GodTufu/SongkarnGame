using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class NpcChain : MonoBehaviour, IWater
{
    public GameObject Cscene;
    public NpcChain Npc2;
    public bool Switch;
    public AudioClip clip;
    public AudioSource source;
    public float volume = 0.1f;
    public int Point = 1;
    // Start is called before the first frame update
    void Start()
    {
        source.volume = volume;
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
            source.PlayOneShot(clip);
            Score.Add(Point);
            Character_Movement.con = false;
            Debug.Log("Hit");
            Npc2.Switch = true;
        }
        else
        {

        }
    }
}
