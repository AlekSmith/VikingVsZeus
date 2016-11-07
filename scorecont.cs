using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorecont : MonoBehaviour {

    public Text scoretext;
    public float score;
    public float Bestscore;
    

    void Start () {
        score = 0f;
        
    }
	
	
	void Update () {
        scoretext.text = "\n" + score;
        if (score > Bestscore)
        {
            Bestscore = score;
        }

    }
}
