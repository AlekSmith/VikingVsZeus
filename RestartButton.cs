using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

    // По нажатию мыши над элементом
    void OnMouseDown()
    {
        // ... повторно загрузить текущий уровень
        Application.LoadLevel(Application.loadedLevel);
    }
}
