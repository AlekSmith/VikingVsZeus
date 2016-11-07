using UnityEngine;
using System.Collections;

public class nextbutton : MonoBehaviour {
    
    // Use this for initialization
    void OnMouseDown()
    {
        // ... повторно загрузить текущий уровень
        if (GetComponentInParent<CharacterPAnel>().por < 3f)
        {
            GameObject.Find("CharacterChoise").transform.Translate(new Vector2(-1.1f, 0.0f));
            GetComponentInParent<CharacterPAnel>().por++;
        }
    }
}
