using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbClick : MonoBehaviour
{
    public AudioClip workClip;  
    public AudioClip relationshipClip;  
    public AudioClip personalClip;  
    public AudioClip leisureClip;  
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (workClip != null)
        {
            audioSource.clip = workClip;
        }
        if (relationshipClip != null)
        {
            audioSource.clip = relationshipClip;
        }
        if (personalClip != null)
        {
            audioSource.clip = personalClip;
        }
        if (leisureClip != null)
        {
            audioSource.clip = leisureClip;
        }
    }

    void OnMouseDown(){
        if (audioSource.isPlaying) 
            {
                audioSource.Stop();
                if (tag =="work") 
                {
                    audioSource.Play();
                    Debug.Log("Work Sprite Clicked");
                }

                if (tag =="personal") 
                {
                    audioSource.Play();
                    Debug.Log("Personal Sprite Clicked");
                }

                if (tag =="relationships") 
                {
                    audioSource.Play();
                    Debug.Log("Relationship Sprite Clicked");
                }

                if (tag =="leisure") 
                {
                    audioSource.Play();
                    Debug.Log("Leisure Sprite Clicked");
                }
            }
            else
            {
                if (tag =="work") 
                {
                    audioSource.Play();
                    Debug.Log("Work Sprite Clicked");
                }

                if (tag =="personal") 
                {
                    audioSource.Play();
                    Debug.Log("Personal Sprite Clicked");
                }

                if (tag =="relationships") 
                {
                    audioSource.Play();
                    Debug.Log("Relationship Sprite Clicked");
                }

                if (tag =="leisure") 
                {
                    audioSource.Play();
                    Debug.Log("Leisure Sprite Clicked");
                }
            }
    }
}
