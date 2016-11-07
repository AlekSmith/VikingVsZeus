using UnityEngine;
using System.Collections;

public class rightcolli : MonoBehaviour {
    public GameObject rightcoll;
    public GameObject leftcolli;
    public Camera came;
    public float maxWidth;


	// Use this for initialization
	void Update () {
        Vector2 cama = new Vector2(Screen.width, Screen.height);
        Vector2 targetWidth = came.ScreenToWorldPoint(cama);
        maxWidth = targetWidth.x; 

        rightcoll.transform.position = new Vector2((maxWidth + 0.1f), 0.422f);
        leftcolli.transform.position = new Vector2(((-maxWidth)- 0.1f), 0.422f);
       





	}
	
	
}
