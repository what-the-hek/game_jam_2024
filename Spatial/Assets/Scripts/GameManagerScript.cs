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
    public TextMeshProUGUI DayText;
    public TextMeshProUGUI endRoundText;
    public TextMeshProUGUI endWeekText;

    // List<string> Days;

    private float roundTimer = 20f;

    // void NewRound()
    // {
    //     Days = new List<string>();
    //     Days.Add("Monday");
    //     Days.Add("Tuesday");
    //     Days.Add("Wednesday");
    //     Days.Add("Thursday");
    //     Days.Add("Friday");
    //     Days.Add("Saturday");
    //     Days.Add("Sunday");

    //     DayText.text = stringToRetrieve;
    // }

    void Update()
    {
        DayText.text = "Monday";
        roundTimer -= Time.deltaTime;
        if (roundTimer <= 0.0f)
        {
            EndRound();
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
            Debug.Log("win");
        }
    }

    void EndRound()
    {   
        enabled = false;
        endRoundText.text = "End of day";
        StartCoroutine(NextRound());
        // if ()
        // {

        // }// if length day <=0 {EndWeek()}
        // else
        // {
        //     EndWeek();
        // }
    }

    private IEnumerator NextRound()
    {
        yield return new WaitForSeconds(7.0f);

        SceneManager.LoadScene("Play");
    }

    // void EndWeek()
    // {
    //     // if length day <=0 {EndGame()}
    // }

    void EndGame()
    {   
        enabled = false;
        endRoundText.text = "End of week";
        // yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(sceneName);

        Debug.Log("game over");
    }

}
