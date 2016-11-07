using UnityEngine;
using System.Collections;

public class SpawnCorotin : MonoBehaviour {
    private Controller theController2;
    public GameObject scoregood;
    public GameObject scoregoodtwo;
    public GameObject scorebad;
    public float maxWidth;
    public Camera cam;
    public GameObject pumper;
    public GameObject GameOver;









    // Use this for initialization
    void Start () {
        theController2 = FindObjectOfType<Controller>();
        
        
            StartCoroutine(Spawn());
            StartCoroutine(Spawntwo());
            StartCoroutine(Spawntreee());
        
        Vector3 cama = new Vector3(Screen.width, Screen.height, 0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(cama);
        maxWidth = targetWidth.x;
        pumper.transform.position = new Vector3(0f, -0.63f, -1f);
        {
            cam = Camera.main;

        }


    }
	
	// Update is called once per frame
	void Update () {
	if (theController2.GameOver == true )
        {
            StopAllCoroutines();
            GameOver.SetActive(true);
            theController2.live = false;
        }
    
	}

    IEnumerator Spawn()
    {


        yield return new WaitForSeconds(2f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.1f), ((maxWidth - 0.1f))),
                1.1f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(scoregood, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(1f, 2f));

        }


    }


    IEnumerator Spawntwo()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.1f), ((maxWidth - 0.1f))),
                1.1f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(scoregoodtwo, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(1f, 2f));

        }




    }

    IEnumerator Spawntreee()
    {
        yield return new WaitForSeconds(4f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.1f), ((maxWidth - 0.1f))),
                1.1f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(scorebad, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(3f, 3f));

        }

    }

}
