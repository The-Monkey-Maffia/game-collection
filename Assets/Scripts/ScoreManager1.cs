using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager1 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void AddPoint1(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
    public void AddPoint2(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
