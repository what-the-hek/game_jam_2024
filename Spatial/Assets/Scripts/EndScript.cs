using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public string sceneName = "";
	public Button startButton;

    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI endWorkScoreText;
    public TextMeshProUGUI endRelationshipScoreText;
    public TextMeshProUGUI endLeisureScoreText;
    public TextMeshProUGUI endPersonalScoreText;
    private void Start()
    {
        Button startBtn = startButton.GetComponent<Button>();
        startBtn.onClick.AddListener(TaskOnClickStart);

        if (globalVariables.totalScore >= 1)
        {
            totalScoreText.text = $"{globalVariables.totalScore}";
            endWorkScoreText.text = $"{globalVariables.workScore}";
            endRelationshipScoreText.text = $"{globalVariables.relationshipScore}";
            endLeisureScoreText.text = $"{globalVariables.leisureScore}";
            endPersonalScoreText.text = $"{globalVariables.personalScore}";
        }
    }

    void TaskOnClickStart(){
		SceneManager.LoadScene(sceneName);
		Debug.Log ("You have clicked the Start!");
	}
}