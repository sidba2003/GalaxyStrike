using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreBoard;

    int score = 0;
    public static Scoreboard instance;

    private void Awake()
    {
        instance = this;
    }

    public void increaseScore()
    {
        score++;
        scoreBoard.text = score.ToString();
    }
}
