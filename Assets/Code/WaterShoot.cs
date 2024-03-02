using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShoot : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float speed=5;
    // Start is called before the first frame update
    void Start()
    {
       rb.velocity = transform.up*speed;
    }

    // Update is called once per frame
    void Update()
    {
    }


}
