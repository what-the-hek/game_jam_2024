using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotAudio : MonoBehaviour
{
    public AudioClip[] workClips;
    public AudioClip[] relationshipClips;
    public AudioClip[] personalClips;
    public AudioClip[] leisureClips;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        AudioClip selectedClip = null;

        // Select a random clip based on the object's tag
        if (tag == "work" && workClips.Length > 0)
        {
            selectedClip = workClips[Random.Range(0, workClips.Length)];
            Debug.Log($"Selected Work Clip: {selectedClip.name}");
        }
        else if (tag == "personal" && personalClips.Length > 0)
        {
            selectedClip = personalClips[Random.Range(0, personalClips.Length)];
            Debug.Log($"Selected Personal Clip: {selectedClip.name}");
        }
        else if (tag == "relationships" && relationshipClips.Length > 0)
        {
            selectedClip = relationshipClips[Random.Range(0, relationshipClips.Length)];
            Debug.Log($"Selected Relationship Clip: {selectedClip.name}");
        }
        else if (tag == "leisure" && leisureClips.Length > 0)
        {
            selectedClip = leisureClips[Random.Range(0, leisureClips.Length)];
            Debug.Log($"Selected Leisure Clip: {selectedClip.name}");
        }

        // Play the selected clip
        if (selectedClip != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            audioSource.clip = selectedClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No audio clip selected. Check if the tag and audio list are correct.");
        }
    }
}
