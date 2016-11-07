using UnityEngine;
using System.Collections;

public class choisescript : MonoBehaviour {
    



   
    // По нажатию мыши над элементом
    void OnMouseDown()
    {
        var readyScreen = GameObject.Find("ReadyScreen");
        readyScreen.transform.position = Vector3.zero;
        
        var caraktel = GameObject.Find("CharacterPanel");
        caraktel.transform.position = (new Vector2(5f, -0.828f));
        var viking = GameObject.Find("Viking");
        viking.transform.position = (new Vector2(0.068f, -0.828f));
       

        if (GetComponentInParent<CharacterPAnel>().por == 1)
        {
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char2 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char3 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char1 = true;
           
            
        }
        if (GetComponentInParent<CharacterPAnel>().por == 2)
        {
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char1 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char3 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char2 = true;
           
        }
        if (GetComponentInParent<CharacterPAnel>().por == 3)
        {
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char1 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char2 = false;
            GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char3 = true;
            

        }
       
    }
}
