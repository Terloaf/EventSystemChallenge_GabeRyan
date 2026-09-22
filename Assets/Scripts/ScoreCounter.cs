using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    public TextMeshProUGUI scoreText;

    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: ";
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

}
