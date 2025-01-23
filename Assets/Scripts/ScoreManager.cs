using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    public void IncreaseScore()
    {
        score += 1;
        UpdateScore();
    }
    
    private void UpdateScore()
    {
        scoreText.text = "Fish Caught: " + score;
    }
}
