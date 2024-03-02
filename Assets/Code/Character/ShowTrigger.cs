using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTrigger : MonoBehaviour
{
    [SerializeField]public GameObject interrac;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interrac.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interrac.SetActive(false);
        }
    }
}
