using UnityEngine;
using System.Collections;

public class Destroyoncontact : MonoBehaviour
{

    // На уничтожение
    void OnTriggerEnter2D(Collider2D other)
    {





        Destroy(other.gameObject, 0);
        




    }

}
