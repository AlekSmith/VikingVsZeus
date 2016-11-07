using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    public bool start;
    public bool GameOver;
    public bool left;
    public bool live;
    public float thrust;
    public float a;
    public float timeLeft;
    public bool conControll;
    
    
    private scorecont theScorecont;
    
    

    
    
    







    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {


            transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(transform.rotation.x, transform.rotation.y, 180, 0), 2.5f * Time.deltaTime);
            
            GameOver = true;
            
            

        }

    }
    void Start()
    {
        live = true;
        theScorecont = FindObjectOfType<scorecont>();
        start = false;// началась  ли игра?
        left = false;
        GameOver = false;

       

        
        
        peredvig();
        thrust = 0.025f;
        conControll = false;

        
      
    }


    void Update()
    {
        peredvig();
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
       
        timeLeft += Time.deltaTime;


    }




    public bool getdiestatus()
    {
        return live;
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Slow")
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(transform.rotation.x, transform.rotation.y, 180, 0), 2.5f * Time.deltaTime);
            
            GameOver = true;


        }
        if (trigger.gameObject.tag == "50kilo")
        {


            float pic = thrust + 0.0002f;
            thrust = pic;
            theScorecont.score += 1f;

            
            

        }







    }




    
    
        

    

    void peredvig()
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


        if (start == true && live == true && timeLeft >= 60)
        {
            thrust = 0.035f;

            if (left)
            {

                transform.localScale = new Vector2(-0.55f, 0.55f);
                transform.Translate(new Vector2(thrust, 0.0f));


            }
            if (!left)
            {

                transform.localScale = new Vector2(0.55f, 0.55f);
                transform.Translate(new Vector2(thrust, 0.0f));

            }
        }
    }


    

   
        
    


}





