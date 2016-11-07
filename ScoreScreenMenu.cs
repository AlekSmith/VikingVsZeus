using UnityEngine;
using System.Collections;

public class ScoreScreenMenu : MonoBehaviour
{
    // Два компонента управления очками - текущими и рекордом
    public ScoresController CurrentScore;
    public ScoresController RecordScore;



    public void SetScores(int scores)
    {
        // Устанавливаем компоненту отображения очков заработанное количество очков
        CurrentScore.SetScores(scores);


    }

    public void SetRecord(int highscores)
    {
        // Устанавливаем компоненту отображения очков текущий рекорд
        RecordScore.SetScores(highscores);
    }
}
