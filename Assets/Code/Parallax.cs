using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;
    public float smooth = 2f;

    // Start is called before the first frame update
    void Start()
    {

        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = Vector3.Lerp(transform.position, new Vector3(startpos + dist, transform.position.y, transform.position.z), smooth);
        //transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
    }
}
