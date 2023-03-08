using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void QuitGame ()
    {
        Debug.Log("Quit!!!!!");
        Application.Quit();
    }

    public void AddScore()
    {
        score += 5;
        scoreText.text = score.ToString();
        
    }
    
    public void SubtractScore()
    {

        score -= 5;
        if (score <0)
        {
            score = 0;
        }
        scoreText.text = score.ToString();
    }

}
