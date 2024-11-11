using UnityEngine;

public class DragAndDrop2D : MonoBehaviour
{
    public Transform slot;          // Slot where the object will be dropped
    public bool isOverSlot = false; // Whether the object is over the slot
    public bool isLocked = false;   // Whether the object is locked in place

    private Vector3 offset;         // Offset between mouse position and object position
    private Vector3 originalPosition; // The original position of the object
    private bool isDragging = false; // Is the object being dragged?

    // Reference to the AudioSource component
    private AudioSource audioSource;

    // Reference to the sound you want to play (drag the sound file here in the Inspector)
    public AudioClip soundClip;

    private scoreManager scoreManager;

    private void Start()
    {
        originalPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
        scoreManager = FindObjectOfType<scoreManager>();
    }

    private void OnMouseDown()
    {
        if (isLocked) return;  // Prevent dragging if the object is locked

        isDragging = true;

        // Calculate the offset from the object's position to the mouse position
        offset = transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        if (!isDragging || isLocked) return;  // Prevent dragging if the object is locked

        // Update the object's position to follow the mouse position, using the calculated offset
        transform.position = GetMouseWorldPosition() + offset;
    }

    private void OnMouseUp()
    {
        if (!isDragging || isLocked) return;  // Prevent releasing if the object is locked

        isDragging = false;

        // If the object is over the slot, lock it in place
        if (isOverSlot)
        {
            LockInSlot();
        }
        else
        {
            // If not over the slot, return the object to its original position
            //transform.position = originalPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("On Trigger Enter");
        if (!isLocked)
        {
            // insert sound here pls
            PlaySoundEffect();
            slot = other.gameObject.transform;
            isOverSlot = true;  // Set to true when the object enters the slot's trigger area
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("On Trigger Exit");
        if (other.transform == slot)
        {
            isOverSlot = false; // Set to false when the object exits the slot's trigger area
            slot = null;
        }
    }

    // Method to lock the object in place when it collides with the slot
    private void LockInSlot()
    {
        if(slot == null) return;

        isLocked = true;  // Lock the object in place
        transform.position = slot.position;  // Set the object's position to the slot's position

        // Optionally, disable the collider to avoid further collisions
        GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;

        // scoring not working
        // if (isLocked)
        // { if (gameObject.CompareTag("work") ||
        //      gameObject.CompareTag("relationships") ||
        //      gameObject.CompareTag("leisure") ||
        //      gameObject.CompareTag("personal"));
        //     {
        //     scoreManager.AddScore(gameObject.tag); //error here
        //     }
        // }
    }

    private void Scoring()
    {
        if (isLocked = true)
            { if (gameObject.CompareTag("work") ||
                gameObject.CompareTag("relationships") ||
                gameObject.CompareTag("leisure") ||
                gameObject.CompareTag("personal"));
                {
                scoreManager.AddScore(gameObject.tag); 
                }
            }
            Debug.Log("Total Score: " + scoreManager.totalScore);
    }

    // Helper method to get the world position of the mouse
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseScreenPosition.z = 0; // Make sure the z-value is 0 (since we are working in 2D)
        return mouseScreenPosition;
    }

        // Method to play the sound
    void PlaySoundEffect()
    {
        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);  // Plays the sound once
        }
    }
}
