using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour , ISplashWater
{
    public Rigidbody2D rb;
    public float speed = 5;
    public int Point = 1;
    public Animator Animator;
    public bool Hit;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SplashWater()
    {
        if (!Hit)
        {
            Hit = true;
            Score.Add(Point);
            Animator.SetBool("Hit", true);            
        }
        
    }
    void OnBecameInvisible()
    {
        if (Hit)
        {
            Destroy(gameObject);
        }        
    }
}
