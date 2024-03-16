using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Npc : MonoBehaviour ,IWater
{
    public AudioClip clip;
    public AudioSource source;
    public float volume = 0.1f;
    public GameObject Cscene;
    public int Point = 2;
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
        Cscene.SetActive(true);
        source.PlayOneShot(clip);
        Score.Add(Point);
        Character_Movement.con = false;
        Debug.Log("Hit");
    }

}
