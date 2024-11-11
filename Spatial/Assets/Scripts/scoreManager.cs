using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public int totalScore = 0;
    public int workScore = 0;
    public int relationshipScore = 0;
    public int personalScore = 0;
    public int leisureScore = 0;


    // Method to increase score based on tag
    public void AddScore(string tag)
    {
        switch(tag)
        {
            case "work":
                totalScore += 1;
                break;
            case "leisure":
                totalScore += 1;
                break;
            case "relationships":
                totalScore += 1;
                break;
            case "personal":
                totalScore += 1;
                break;
            default:
                break;
        }
        Debug.Log("Total Score: " + totalScore);
        
        switch(tag)
        {
            case "work":
                workScore += 1;
                break;
            case "leisure":
                leisureScore += 1;
                break;
            case "relationships":
                relationshipScore += 1;
                break;
            case "personal":
                personalScore += 1;
                break;
            default:
                break;
        }
        Debug.Log("work score: " + workScore);
        Debug.Log("leisure score: " + leisureScore);
        Debug.Log("relationship score: " + relationshipScore);
        Debug.Log("personal score: " + personalScore);
    }
}
