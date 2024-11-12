using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public globalVariables globalVariables;
    public scoreManager scoreManager;
    public TextMeshProUGUI scoreText;

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
}
