using UnityEngine;
using System.Collections;

public class zeushand : MonoBehaviour {

    void Start()
    {
        Destroy(gameObject, 1.5f);
    }



    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
           
            Destroy(gameObject, 0.1f);
        }
    }
}
