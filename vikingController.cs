using UnityEngine;
using System.Collections;

public class vikingController : MonoBehaviour
{


    public AudioClip Atackclip, Molniclip, Deadclip, Ringclip;
    public float timeLeft;
    public bool left;
    public bool live;
    public float thrust;
    public bool start;
    public GameObject Xpa;
    public float lives;
    public GameObject liveheart;
    public float xp = 0f;
    public float lvl = 1f;
    void Start()
    {
        start = false;// началась  ли игра?
        left = false;
        GameObject.Find("sprite").GetComponent<Animator>().SetTrigger("stay");
        lives = 4f;
        thrust = 0.005f;
        live = true;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        Peredvig();
        timeLeft += Time.deltaTime;
       
    }

    // Когда игровой объект, на котором расположен текущий компонент...
    // своим коллайдером коснется коллайдера-триггера
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Slow")
        {
            GameObject.Find("sprite").GetComponent<Animator>().SetTrigger("banhit");
            liveheart.transform.Translate(new Vector2(-0.07f, 0.0f));
            GameObject.Find("Background").GetComponent<Animator>().SetTrigger("vibrate");
            Handheld.Vibrate();

            AudioSource.PlayClipAtPoint(Molniclip, Camera.main.transform.position);
            lives = lives -1;
            

            if (lives == 0f)
            {
                Die();
            }

        }
        if (trigger.gameObject.tag == "50kilo")
        {

            AudioSource.PlayClipAtPoint(Atackclip, Camera.main.transform.position);
            thrust = thrust + 0.0002f;
            xp = xp +1;
            Xpa.transform.Translate(new Vector2(0.025f, 0.0f));

            if (xp == 20f)
            {
                lvl = 2f;
                Xpa.transform.position = (new Vector2(- 0.2142f, -0.03f));
            }
            
            
                GameObject.Find("sprite").GetComponent<Animator>().SetTrigger("atack");


                ;
                Destroy(GameObject.FindGameObjectWithTag("50kilo"), 0.2f);

            
            

             
   }

        if (trigger.gameObject.tag == "Enemy")
        {   
            
            Die();
        }

        if (trigger.gameObject.tag == "Scores")
        {
            GetScore();
            Destroy(GameObject.FindGameObjectWithTag("Scores"), 0.1f);
        }


        if (trigger.gameObject.tag == "leg")
        {
            thrust = thrust + 0.0002f;
            if (left == true)
            {
                left = false;
            }
           

            
        }
        if (trigger.gameObject.tag == "legright")
        {
            thrust = thrust + 0.0002f;

            if (left == false)
            {
                left = true;
            }

        }




    }


    void Peredvig()
    {
        if (GameController.GameStarted == true)
        {


            if (Input.GetMouseButtonDown(0))
            {


                if (start == false)
                {
                    start = true;

                }
                if (start == true && live == true)
                    if (left == false)
                    {
                        left = true;
                    }
                    else
                        left = false;
            }

            if (start == true && live == true)
            {


                GameObject.Find("sprite").GetComponent<Animator>().SetBool("run", true);








                if (left)
                {
                    transform.localScale = new Vector2(-0.55f, 0.55f);
                    transform.Translate(new Vector2(-thrust, 0.0f));


                }
                if (!left)
                {
                    transform.localScale = new Vector2(0.55f, 0.55f);
                    transform.Translate(new Vector2(thrust, 0.0f));

                }
            }



        }
    }





    void Die()
    {

        GameObject.Find("sprite").GetComponent<Animator>().SetTrigger("dead");

        GameObject.Find("Viking").GetComponent<Collider2D>().enabled = false;
        // Находим игровой объект, содержащий компонент GameController и сообщаем, что игра завершена
        GameObject.Find("_GameController").GetComponent<GameController>().EndGame();

        // Сбрасываем текущую скорость
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;


        // Отключаем компонент
        enabled = false;




        
        AudioSource.PlayClipAtPoint(Deadclip, Camera.main.transform.position);
        
    }

    void GetScore()
    {
        // Увеличиваем количество очков
        GameController.Scores++;

        AudioSource.PlayClipAtPoint(Ringclip, Camera.main.transform.position);
        // Добвить анимацию пожирания очков


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            // добавить анимацию смерти,если перевораиваться не будет то добавить условие if (left){transform.localScale = new Vector2(-0.55f, 0.55f);}
            Die();





        }
        // if (coll.gomeObject.tag == "Bonus"){
        // //GetComponent<Animator>().SetTrigger("Bonus");
        // И выполнение на несколько секунд
    }

}
