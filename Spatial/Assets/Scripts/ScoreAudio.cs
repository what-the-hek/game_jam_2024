using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAudio : MonoBehaviour
{
    public globalVariables globalVariables;

    private AudioClip workClip;
    public AudioClip workClip1; 
    public AudioClip workClip2;  
    public AudioClip workClip3;  
    public AudioClip workClip4;  
    public AudioClip workClip5;  
    public AudioClip workClip6;  

    private AudioClip relationshipClip;
    public AudioClip relationshipClip1; 
    public AudioClip relationshipClip2;  
    public AudioClip relationshipClip3;  
    public AudioClip relationshipClip4;  
    public AudioClip relationshipClip5;  
    public AudioClip relationshipClip6; 

    private AudioClip personalClip;
    public AudioClip personalClip1; 
    public AudioClip personalClip2;  
    public AudioClip personalClip3;
    public AudioClip personalClip4;
    public AudioClip personalClip5;
    public AudioClip personalClip6;

    private AudioClip leisureClip;
    public AudioClip leisureClip1;
    public AudioClip leisureClip2;  
    public AudioClip leisureClip3;  
    public AudioClip leisureClip4;  
    public AudioClip leisureClip5;  
    public AudioClip leisureClip6;    

    private AudioSource audioSourceWork;
    private AudioSource audioSourcePersonal;
    private AudioSource audioSourceRelationship;
    private AudioSource audioSourceLeisure;

    void Start()
    {
        audioSourceWork = GetComponent<AudioSource>();
        audioSourcePersonal = GetComponent<AudioSource>();
        audioSourceRelationship = GetComponent<AudioSource>();
        audioSourceLeisure = GetComponent<AudioSource>();

        globalVariables.workScore = 0;
        globalVariables.relationshipScore = 0;
        globalVariables.personalScore = 0;
        globalVariables.leisureScore = 26;

        if (globalVariables.workScore > 0 ) 
        {
            if (globalVariables.workScore >= 1 && globalVariables.workScore <= 5) 
            {
                workClip = workClip1;
                Debug.Log("Work score between 1 and 5");
            }
            if (globalVariables.workScore >= 6 && globalVariables.workScore <= 10) 
            {
                workClip = workClip2;
                Debug.Log("Work score between 6 and 10");
            }
            if (globalVariables.workScore >= 11 && globalVariables.workScore <= 15) 
            {
                workClip = workClip3;
                Debug.Log("Work score between 11 and 15");
            }
            if (globalVariables.workScore >= 16 && globalVariables.workScore <= 20) 
            {
                workClip = workClip4;
                Debug.Log("Work score between 16 and 20");
            }
            if (globalVariables.workScore >= 21 && globalVariables.workScore <= 25) 
            {
                workClip = workClip5;
                Debug.Log("Work score between 21 and 25");
            }
            if (globalVariables.workScore >= 26) 
            {
                workClip = workClip6;
                Debug.Log("Work score >= 26");
            }
        }

        if (globalVariables.personalScore > 0 ) 
        {
            if (globalVariables.personalScore >= 1 && globalVariables.personalScore <= 5) 
            {
                personalClip = personalClip1;
                Debug.Log("personal score between 1 and 5");
            }
            if (globalVariables.personalScore >= 6 && globalVariables.personalScore <= 10) 
            {
                personalClip = personalClip2;
                Debug.Log("personal score between 6 and 10");
            }
            if (globalVariables.personalScore >= 11 && globalVariables.personalScore <= 15) 
            {
                personalClip = personalClip3;
                Debug.Log("personal score between 11 and 15");
            }
            if (globalVariables.personalScore >= 16 && globalVariables.personalScore <= 20) 
            {
                personalClip = personalClip4;
                Debug.Log("personal score between 16 and 20");
            }
            if (globalVariables.personalScore >= 21 && globalVariables.personalScore <= 25) 
            {
                personalClip = personalClip5;
                Debug.Log("personal score between 21 and 25");
            }
            if (globalVariables.personalScore >= 26) 
            {
                personalClip = personalClip6;
                Debug.Log("personal score >= 26");
            }
        }


        if (globalVariables.relationshipScore > 0 ) 
        {
            if (globalVariables.relationshipScore >= 1 && globalVariables.relationshipScore <= 5) 
            {
                relationshipClip = relationshipClip1;
                Debug.Log("relationship score between 1 and 5");
            }
            if (globalVariables.relationshipScore >= 6 && globalVariables.relationshipScore <= 10) 
            {
                relationshipClip = relationshipClip2;
                Debug.Log("relationship score between 6 and 10");
            }
            if (globalVariables.relationshipScore >= 11 && globalVariables.relationshipScore <= 15) 
            {
                relationshipClip = relationshipClip3;
                Debug.Log("relationship score between 11 and 15");
            }
            if (globalVariables.relationshipScore >= 16 && globalVariables.relationshipScore <= 20) 
            {
                relationshipClip = relationshipClip4;
                Debug.Log("relationship score between 16 and 20");
            }
            if (globalVariables.relationshipScore >= 21 && globalVariables.relationshipScore <= 25) 
            {
                relationshipClip = relationshipClip5;
                Debug.Log("relationship score between 21 and 25");
            }
            if (globalVariables.relationshipScore >= 26) 
            {
                relationshipClip = relationshipClip6;
                Debug.Log("relationship score >= 26");
            }
        }


        if (globalVariables.leisureScore > 0 ) 
        {
            if (globalVariables.leisureScore >= 1 && globalVariables.leisureScore <= 5) 
            {
                leisureClip = leisureClip1;
                Debug.Log("leisure score between 1 and 5");
            }
            if (globalVariables.leisureScore >= 6 && globalVariables.leisureScore <= 10) 
            {
                leisureClip = leisureClip2;
                Debug.Log("leisure score between 6 and 10");
            }
            if (globalVariables.leisureScore >= 11 && globalVariables.leisureScore <= 15) 
            {
                leisureClip = leisureClip3;
                Debug.Log("leisure score between 11 and 15");
            }
            if (globalVariables.leisureScore >= 16 && globalVariables.leisureScore <= 20) 
            {
                leisureClip = leisureClip4;
                Debug.Log("leisure score between 16 and 20");
            }
            if (globalVariables.leisureScore >= 21 && globalVariables.leisureScore <= 25) 
            {
                leisureClip = leisureClip5;
                Debug.Log("leisure score between 21 and 25");
            }
            if (globalVariables.leisureScore >= 26) 
            {
                leisureClip = leisureClip6;
                Debug.Log("leisure score >= 26");
            }
        }

        if (leisureClip != null) 
        {
        audioSourceLeisure.PlayOneShot(leisureClip, 0.3f);
        }
        if (personalClip != null) 
        {
        audioSourcePersonal.PlayOneShot(personalClip, 0.3f);
        }
        if (relationshipClip != null) 
        {
        audioSourceRelationship.PlayOneShot(relationshipClip, 0.3f);
        }
        if (workClip != null) 
        {
        audioSourceWork.PlayOneShot(workClip, 1.0f);
        }
    }
}
