using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public string sceneName = "";
    // int randomNumber;
    // string stringToRetrieve;
    public globalVariables globalVariables;
    public scoreManager scoreManager;
    public TextMeshProUGUI workScoreText;
    public TextMeshProUGUI relationshipScoreText;
    public TextMeshProUGUI leisureScoreText;
    public TextMeshProUGUI personalScoreText;
    public TextMeshProUGUI DayText;
    public TextMeshProUGUI endRoundText;
    public TextMeshProUGUI endWeekText;
    // this is the lazy way, should turn into same as orb spawn
    public TextMeshProUGUI toDo1Text;
    public TextMeshProUGUI toDo2Text;
    public TextMeshProUGUI toDo3Text;
    public TextMeshProUGUI toDo4Text;
    public TextMeshProUGUI toDo5Text;
    int randomNumber1;
    string stringToRetrieve1;
    int randomNumber2;
    string stringToRetrieve2;
    int randomNumber3;
    string stringToRetrieve3;
    int randomNumber4;
    string stringToRetrieve4;
    int randomNumber5;
    string stringToRetrieve5;
    // int previousInstructionIndex = 0;

    // List<string> Days;
    List<string> toDoList;

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
    void Start()
    {
        toDoList = new List<string>();
        toDoList.Add("go to work");
        toDoList.Add("call mum");
        toDoList.Add("get coffee");
        toDoList.Add("walk the dog");
        toDoList.Add("run a bath");
        toDoList.Add("have a picnic");
        toDoList.Add("see a movie");
        toDoList.Add("schedule appointment");
        toDoList.Add("pick up kids");
        toDoList.Add("learn new recipe");
        toDoList.Add("study");
        toDoList.Add("go for a ride");
        toDoList.Add("invite family to dinner");
        toDoList.Add("play a game");
        toDoList.Add("music lessons");
        toDoList.Add("catch up with friends");
        toDoList.Add("concert tonight!");
        toDoList.Add("bunnings trip");
        toDoList.Add("grocery shopping");
        toDoList.Add("do some gardening");


        // do
        // {
        //     randomNumber = Random.Range(0, 10);
        // }
        // while (randomNumber == previousInstructionIndex);

        // previousInstructionIndex = randomNumber;
        // stringToRetrieve1 = toDoList[randomNumber].ToString();
        // toDo1Text.text = stringToRetrieve1;
        // toDo2Text.text = stringToRetrieve2;
        // toDo3Text.text = stringToRetrieve3;
        // toDo4Text.text = stringToRetrieve4;
        // toDo5Text.text = stringToRetrieve5;

        // super lazy way to do this, will refactor later - needs some kind of check so it doesn't duplicate
        randomNumber1 = Random.Range(0, 10);
        stringToRetrieve1 = toDoList[randomNumber1].ToString();
        randomNumber2 = Random.Range(0, 10);
        stringToRetrieve2 = toDoList[randomNumber2].ToString();
        randomNumber3 = Random.Range(0, 10);
        stringToRetrieve3 = toDoList[randomNumber3].ToString();
        randomNumber4 = Random.Range(0, 10);
        stringToRetrieve4 = toDoList[randomNumber4].ToString();
        randomNumber5 = Random.Range(0, 10);
        stringToRetrieve5 = toDoList[randomNumber5].ToString();
        toDo1Text.text = stringToRetrieve1;
        toDo2Text.text = stringToRetrieve2;
        toDo3Text.text = stringToRetrieve3;
        toDo4Text.text = stringToRetrieve4;
        toDo5Text.text = stringToRetrieve5;

        // randomNumber = Random.Range(0, 10);
        // stringToRetrieve = toDoList[randomNumber].ToString();
        // toDo1Text.text = stringToRetrieve;
    }

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
        endWeekText.text = "End of week";
        // yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(sceneName);

        Debug.Log("game over");
    }

}
