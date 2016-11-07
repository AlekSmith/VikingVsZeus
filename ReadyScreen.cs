using UnityEngine;
using System.Collections;

public class ReadyScreen : MonoBehaviour 
{

	
        // При нажатии кнопки выстрела ...
        void OnMouseDown()
        {
            // ... если компонент активен, то сообщаем компоненту управления игрой о старте игры
            GameObject.Find("_GameController").GetComponent<GameController>().StartGame();

            // Отключаем текущий игровой объект (Update перестает вызываться)
            gameObject.SetActive(false);
        

    }
	}

