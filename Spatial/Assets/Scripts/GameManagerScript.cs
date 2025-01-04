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

    List<string> DayList;
    string dayStringToRetrieve;
    List<string> toDoList;

    private float roundTimer = 18f;

    void Start()
    {
        globalVariables.roundCount++;

        if (globalVariables.roundCount >= 8)
        {   
            globalVariables.workScore = 0;
            globalVariables.relationshipScore = 0;
            globalVariables.leisureScore = 0;
            globalVariables.personalScore = 0;
            globalVariables.roundCount = 1;
            EndGame();
        }

        DayList = new List<string>();
        DayList.Add("day0");
        DayList.Add("Monday");
        DayList.Add("Tuesday");
        DayList.Add("Wednesday");
        DayList.Add("Thursday");
        DayList.Add("Friday");
        DayList.Add("Saturday");
        DayList.Add("Sunday");

        dayStringToRetrieve = DayList[globalVariables.roundCount].ToString();
        DayText.text = dayStringToRetrieve;

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
        toDoList.Add("meditate");

        toDoList.Add("do house repairs");
        toDoList.Add("pay bills");
        toDoList.Add("read a book");
        toDoList.Add("do an online course");
        toDoList.Add("respond to that text");
        toDoList.Add("volunteer work");
        toDoList.Add("babysit");
        toDoList.Add("do the dishes");
        toDoList.Add("go to the gym");
        toDoList.Add("plan birthday party");

        // super lazy way to do this, will refactor later - needs some kind of check so it doesn't duplicate
        randomNumber1 = Random.Range(0, 31);
        stringToRetrieve1 = toDoList[randomNumber1].ToString();
        randomNumber2 = Random.Range(0, 31);
        stringToRetrieve2 = toDoList[randomNumber2].ToString();
        randomNumber3 = Random.Range(0, 31);
        stringToRetrieve3 = toDoList[randomNumber3].ToString();
        randomNumber4 = Random.Range(0, 31);
        stringToRetrieve4 = toDoList[randomNumber4].ToString();
        randomNumber5 = Random.Range(0, 31);
        stringToRetrieve5 = toDoList[randomNumber5].ToString();
        toDo1Text.text = stringToRetrieve1;
        toDo2Text.text = stringToRetrieve2;
        toDo3Text.text = stringToRetrieve3;
        toDo4Text.text = stringToRetrieve4;
        toDo5Text.text = stringToRetrieve5;
    }

    void Update()
    {
        roundTimer -= Time.deltaTime;
        if (roundTimer <= 0.0f)
        {
            EndRound();
        }
        else ScoreText();

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();

            Debug.Log("Quit Game.");
        }
    }
    
    void ScoreText()
    {
        if (globalVariables.totalScore >= 1)
        {
            workScoreText.text = $"{globalVariables.workScore}";
            relationshipScoreText.text = $"{globalVariables.relationshipScore}";
            leisureScoreText.text = $"{globalVariables.leisureScore}";
            personalScoreText.text = $"{globalVariables.personalScore}";
        }
    }

    void EndRound()
    {   
        enabled = false;
        if (globalVariables.roundCount <= 6)
        {
            endRoundText.text = $"End of day {globalVariables.roundCount}";
            StartCoroutine(NextRound());            
        }
        else if (globalVariables.roundCount >= 7)
        {
            endRoundText.text = "End of week";
            StartCoroutine(EndGame());  
        }
    }

    private IEnumerator NextRound()
    {
        enabled = false;
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene("Play");
    }

    private IEnumerator EndGame()
    {   
        enabled = false;
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene(sceneName);
    }

}
