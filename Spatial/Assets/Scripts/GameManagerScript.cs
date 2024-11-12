using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public globalVariables globalVariables;
    public scoreManager scoreManager;
    public TextMeshProUGUI scoreText;

    private float roundTimer = 10f;

    void Update()
    {
        roundTimer -= Time.deltaTime;
        if (roundTimer <= 0.0f)
        {
            EndGame();
        }
        else PlayState();
    }
    void PlayState()
    {
        if (globalVariables.totalScore >= 1)
        {
            scoreText.text = "You win!";
            Debug.Log("win");
        }
        if (scoreManager.localTotalScore >= 1)
        {
            scoreText.text = "Yay!";
            Debug.Log("yay");
        }
        else {            
            scoreText.text = "no!";
            Debug.Log("no");}
    }

    void EndGame()
    {
        Debug.Log("game over");
    }

}
