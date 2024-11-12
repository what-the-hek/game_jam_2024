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
    
    public void AddScore()
    {  
        if (tag == "work" || tag == "leisure" || tag == "relationships" || tag == "personal") 
            {
                totalScore += 1;
            }
        Debug.Log("total score: " + totalScore);

        if (tag == "work")
            {
                workScore += 1;
            }
        Debug.Log("work score: " + workScore);

        if (tag == "leisure")
            {
                leisureScore += 1;
            }
        Debug.Log("leisure score: " + leisureScore);

        if (tag == "relationships")
            {
                relationshipScore += 1;
            }
        Debug.Log("relationships score: " + relationshipScore);

        if (tag == "personal")
            {
                personalScore += 1;
            }
        Debug.Log("personal score: " + personalScore);
    }
}
