using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_control : MonoBehaviour
{
    [SerializeField] private Transform ray;
    public float distance = 0.4f;
    public float distanceWater = 1.5f;
    public Animator animator;
    // public GameObject waterShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Shoot");
            water();
        }
        if (Input.GetButtonDown("Jump"))
        {
            SplashWater();
            animator.SetTrigger("Attack");
        }

    }

    public void water()
    {        
        RaycastHit2D[] Enemy = Physics2D.RaycastAll(ray.transform.position, transform.right*gameObject.transform.localScale.x, distance);
        foreach (var item in Enemy)
        {

            if (item.collider.name != gameObject.name)
            {
                if (item.collider.GetComponent<IWater>() != null)
                {
                    item.collider.GetComponent<IWater>().Splash();
                }                
            }
            else
            {

            }
        }
    }

    public void SplashWater()
    {
        RaycastHit2D[] Enemy = Physics2D.RaycastAll(ray.transform.position, transform.right * gameObject.transform.localScale.x, distanceWater);
        foreach (var item in Enemy)
        {

            if (item.collider.name != gameObject.name)
            {
                if (item.collider.GetComponent<ISplashWater>() != null)
                {
                    item.collider.GetComponent<ISplashWater>().SplashWater();
                }
            }
            else
            {

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(ray.transform.position, ray.transform.position + transform.right * gameObject.transform.localScale.x * distance);
        Gizmos.DrawLine(ray.transform.position, ray.transform.position + transform.right * gameObject.transform.localScale.x * distanceWater);
    }
}
