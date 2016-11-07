using UnityEngine;
using System.Collections;

public class velocityscore : MonoBehaviour {

    public float speed = 100f;
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().angularVelocity = 200;
	}
}
