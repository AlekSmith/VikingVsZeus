using UnityEngine;
using System.Collections;

public class char1Select : MonoBehaviour {

    // По нажатию мыши над элементом
    void OnMouseDown()
    {
        // ... повторно загрузить текущий уровень
        GameObject.Find("CharacterPanel").GetComponent<CharacterPAnel>().char1 = true;
    }
}
