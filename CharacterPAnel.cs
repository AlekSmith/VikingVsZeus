using UnityEngine;
using System.Collections;

public class CharacterPAnel : MonoBehaviour {
    public bool char1;
    public bool char2;
    public bool char3;
    public int por;
    
    public static int Numplayer;
    
    public GameController MainGameController;
    // Use this for initialization

        void Awake()
    {
        
        
    }


    void Start () {
        por = 1;
        Numplayer = PlayerPrefs.GetInt("Numplayer", Numplayer);
        char1 = false;
        char2 = false;
        char3 = false;
        selectedchar();

        if (por < 2)
        {
            por = Numplayer;
        }
        

    }
	
	// Update is called once per frame
	void Update () {
        /*if (char1 == false && char2 == false && char3 == false) вписать это все в викинг контроллер
            {
                char1 = true;
            }
            */
      
            Numplayer = por;

        if (MainGameController.GameOver == true)
            
        {

            
            if (por == 1)
            {

                GameObject.Find("CharacterChoise").transform.position = (new Vector2(2.22f, -0.4455f));


            }
            if (por == 2)
            {

                GameObject.Find("CharacterChoise").transform.position = (new Vector2(1.12f, -0.4455f));
            }
            if (por == 3)
            {

                GameObject.Find("CharacterChoise").transform.position = (new Vector2(0.01999998f, -0.4455f));

            }
        }
        
       









        PlayerPrefs.SetInt("Numplayer", Numplayer);
    }
    public void selectedchar()
    {
        if (Numplayer == 1)
        {
            char2 = false;
            char3 = false;
            char1 = true;
        }
        if (Numplayer == 2)
        {
            char3 = false;
            char1 = false;
            char2 = true;
        }
        if (Numplayer == 3)
        {
            char1 = false;
            char2 = false;
            char3 = true;
        }
    }
   
}
