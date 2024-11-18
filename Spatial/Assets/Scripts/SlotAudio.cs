using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotAudio : MonoBehaviour
{
    public AudioClip workClip;
    public AudioClip relationshipClip;
    public AudioClip personalClip;
    public AudioClip leisureClip;

    public AudioSource audioSource;

    public void PlaySound()
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

        if (audioSource.isPlaying) 
            {
                audioSource.Stop();
                if (tag =="work") 
                {
                    audioSource.Play();
                    Debug.Log("Work locked");
                }

                if (tag =="personal") 
                {
                    audioSource.Play();
                    Debug.Log("Personal locked");
                }

                if (tag =="relationships") 
                {
                    audioSource.Play();
                    Debug.Log("Relationship locked");
                }

                if (tag =="leisure") 
                {
                    audioSource.Play();
                    Debug.Log("Leisure locked");
                }
            }
            else
            {
                if (tag =="work") 
                {
                    audioSource.Play();
                    Debug.Log("Work locked");
                }

                if (tag =="personal") 
                {
                    audioSource.Play();
                    Debug.Log("Personal locked");
                }

                if (tag =="relationships") 
                {
                    audioSource.Play();
                    Debug.Log("Relationship locked");
                }

                if (tag =="leisure") 
                {
                    audioSource.Play();
                    Debug.Log("Leisure locked");
                }
            }
    }
}
