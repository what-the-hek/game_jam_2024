using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public TextMeshProUGUI endWorkScoreText;
    public TextMeshProUGUI endRelationshipScoreText;
    public TextMeshProUGUI endLeisureScoreText;
    public TextMeshProUGUI endPersonalScoreText;
    private void Start()
    {
        if (globalVariables.totalScore >= 1)
        {
            endWorkScoreText.text = $"{globalVariables.workScore}";
            endRelationshipScoreText.text = $"{globalVariables.relationshipScore}";
            endLeisureScoreText.text = $"{globalVariables.leisureScore}";
            endPersonalScoreText.text = $"{globalVariables.personalScore}";
        }
    }
}