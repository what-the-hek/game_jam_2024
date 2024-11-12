using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public string sceneName = "";
    public globalVariables globalVariables;
    public scoreManager scoreManager;
    public TextMeshProUGUI workScoreText;
    public TextMeshProUGUI relationshipScoreText;
    public TextMeshProUGUI leisureScoreText;
    public TextMeshProUGUI personalScoreText;

    private float roundTimer = 10f;

    void Update()
    {
        roundTimer -= Time.deltaTime;
        if (roundTimer <= 0.0f)
        {
            EndGame();
        }
        else ScoreText();
    }
    void ScoreText()
    {
        if (globalVariables.totalScore >= 1)
        {
            workScoreText.text = $"{globalVariables.workScore}";
            relationshipScoreText.text = $"{globalVariables.relationshipScore}";
            leisureScoreText.text = $"{globalVariables.leisureScore}";
            personalScoreText.text = $"{globalVariables.personalScore}";
            // scoreText.text = "You win!";
            Debug.Log("win");
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("game over");
    }

}
