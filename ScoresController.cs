using UnityEngine;
using System.Collections;

public class ScoresController : MonoBehaviour
{
    static  int score = 0;
   
    // Спрайты для первой и второй цифры
    public SpriteRenderer FirstLetter;
    public SpriteRenderer SecondLetter;
    public SpriteRenderer ThirdLetter;
    
    // Массив спрайтов цифр
    public Sprite[] Numbers;
    


    public static void Addpoint()
    {
        score++;
      
    }
    // Метод включения/отключения отображения очков
    public void SetVisible(bool value)
    {
        FirstLetter.enabled = value;
        SecondLetter.enabled = value;
        ThirdLetter.enabled = value;
    }

    // Метод установки текущего значения очков
    public void SetScores(int scores)
    {





        


            ThirdLetter.sprite = Numbers[scores / 100];
            int exer = scores % 100;
            FirstLetter.sprite = Numbers[exer % 10];
            SecondLetter.sprite = Numbers[exer / 10];

        




    }
}
