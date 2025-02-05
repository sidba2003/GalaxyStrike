using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreBoard;

    int score = 0;
    public static Scoreboard instance;

    private void Start()
    {
        instance = this;
    }

    public void increaseScore()
    {
        score++;
        scoreBoard.text = score.ToString();
    }
}
