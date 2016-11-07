using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerScript : MonoBehaviour
{
    public Camera cam;
    public float timeLeft;
    public GameObject scoregood;
    public GameObject scoregoodtwo;
    public GameObject scorebad;
    public bool conControll;
    public Text scoreText;

    public int medalValue;



   

    public float maxWidth;
   

    void Start()
    {
        conControll = false;
        Vector3 cama = new Vector3(Screen.width, Screen.height, 0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(cama);
        maxWidth = targetWidth.x;
        {
            cam = Camera.main;




            StartCoroutine(Spawn());
            StartCoroutine(Spawntwo());
            StartCoroutine(Spawntreee());



        }
        
        
    }

    void Update()
    {
        timeLeft += Time.deltaTime;


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
        //yield return new WaitForSeconds(2.0f);// через две секунды запускает геймовер
        //GameOverText.SetActive(true);// делаем активным игровой объект 
        //yield return new WaitForSeconds(2.0f);// 
        //RestartButton.SetActive(true);

    }


    void destroyscoreone()
    {
        if (timeLeft >= 5)

        {


            StopAllCoroutines();






        }

    }

    IEnumerator Spawntwo()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.1f), ((maxWidth - 0.1f))),
                Screen.height,
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

    public void ToggleControl(bool toggle)
    {
        conControll = toggle;

    }
}
    
