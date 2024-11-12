using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public globalVariables globalVariables;
    public int localTotalScore;

    public void AddScore()
    {  
        if (tag == "work" || tag == "leisure" || tag == "relationships" || tag == "personal") 
            {
                globalVariables.totalScore += 1;
                localTotalScore = globalVariables.totalScore;
            }
        Debug.Log("total score: " + globalVariables.totalScore);
        Debug.Log("local score: " + localTotalScore);

        if (tag == "work")
            {
                globalVariables.workScore += 1;
            }
        Debug.Log("work score: " + globalVariables.workScore);

        if (tag == "leisure")
            {
                globalVariables.leisureScore += 1;
            }
        Debug.Log("leisure score: " + globalVariables.leisureScore);

        if (tag == "relationships")
            {
                globalVariables.relationshipScore += 1;
            }
        Debug.Log("relationships score: " + globalVariables.relationshipScore);

        if (tag == "personal")
            {
                globalVariables.personalScore += 1;
            }
        Debug.Log("personal score: " + globalVariables.personalScore);
    }
}
