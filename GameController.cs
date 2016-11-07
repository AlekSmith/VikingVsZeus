using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public static int Scores;

    // Массив спрайтов цифр
    
    public static int Record;
    public Camera cam;
    public GameObject scoregood;
    public GameObject scoregoodtwo;
    public GameObject scorebad;
    public GameObject pointscore;
    public GameObject helathscore;
    
    public float maxWidth;
    public float maxHight;

    
    


    // Закончилась ли игра?
    public static bool GameStarted = false;

    // Закончилась ли игра?
    public  bool GameOver = false;

  
    // Связь с компонентом, отвечающим за управление отображением текущего количества очков
    public ScoresController MainScores;
    /*void Awake()
    {
        // Помещаем окно ожидания в центр экрана
        var readyScreen = GameObject.Find("ReadyScreen");
        readyScreen.transform.position = Vector3.zero;
    }*/
    void Start()
    { 
        Vector3 cama = new Vector3(Screen.width, Screen.height, 0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(cama);
        Vector3 targetHight = cam.ScreenToWorldPoint(cama);
        maxWidth = targetWidth.x;
        maxHight = targetHight.y;
        Scores = 0;
        Record = PlayerPrefs.GetInt("Record", Record);
        var scoresScreen = GameObject.FindGameObjectWithTag("ScoreScreen");
        ScoreScreenMenu scoreScreenMenu = scoresScreen.GetComponent<ScoreScreenMenu>();
        
        scoreScreenMenu.SetRecord(Record);

        // Вызывается при каждой загрузке уровня. Сбрасываем настройки текущей игры
        MainScores.SetVisible(true);
        GameOver = false;
        
       

       
    }


    void Update()
    {
        // Каждый кадр сообщаеем компоненту отрисовки заработанных очков обновить текущее значение
        MainScores.SetScores(Scores);
        if (Scores > Record)
        {
            Record = Scores;


        }


    }

    public void StartGame()
    {
        GameStarted = true;
   
       
       

        StartCoroutine(Spawn());
        StartCoroutine(Spawntwo());
        StartCoroutine(Spawntreee());
        StartCoroutine(Spawnfour());
        StartCoroutine(Spawnfive());

    }
    
    public void EndGame()
    {
        GameOver = true;

        // Запоминаем рекорд
        
        StopAllCoroutines();
       
        PlayerPrefs.SetInt("Record", Record);
        // Включаем аниматор у экрана очков, тем самым будет проиграна его единственная анимация
        var scoresScreen = GameObject.FindGameObjectWithTag("ScoreScreen");
        scoresScreen.transform.position = Vector3.zero;
        scoresScreen.GetComponent<Animator>().enabled = true;

        // Указываем меню текущее количество очков и рекорд
        ScoreScreenMenu scoreScreenMenu = scoresScreen.GetComponent<ScoreScreenMenu>();
        
        scoreScreenMenu.SetRecord(Record);
        scoreScreenMenu.SetScores(Scores);
       
    }

    IEnumerator Spawn()
    {


        yield return new WaitForSeconds(2f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.1f), ((maxWidth - 0.1f))),
                (maxHight + 0.05f),
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
    IEnumerator Spawntwo()
    {
        yield return new WaitForSeconds(3f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.2f), ((maxWidth - 0.2f))),
                maxHight - 0.05f,
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
                Random.Range(((-maxWidth) + 0.2f), ((maxWidth - 0.2f))),
                maxHight - 0.05f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(scorebad, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(3f, 3f));

        }

    }




    IEnumerator Spawnfour()
    {
        yield return new WaitForSeconds(6f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.2f), ((maxWidth - 0.2f))),
                maxHight - 0.05f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(pointscore, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(4f, 4f));

        }

    }




    IEnumerator Spawnfive()
    {
        yield return new WaitForSeconds(6f);

        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(((-maxWidth) + 0.2f), ((maxWidth - 0.2f))),
                maxHight - 0.05f,
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(helathscore, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(10f, 15f));

        }

    }
    

}
