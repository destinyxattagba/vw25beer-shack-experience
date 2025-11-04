using UnityEngine;
using System.Collections;

public class MoveCloserOnClick : MonoBehaviour
{
    public Transform playerCamera;   // Assign your XR camera here
    public float moveDistance = 0.3f; // How close the object should come
    public float moveSpeed = 2f;      // How fast it moves
    public AudioSource crunchAudio;


    public bool isClose = false;
    public Vector3 originalPosition;
    public Vector3 targetPosition;
    public float respawnDelay = 5f;

    void Start()
    {
        // Save the starting position
        originalPosition = transform.position;
        targetPosition = originalPosition; // initialize
    }

    void Update()
    {
        // Each frame, move smoothly toward the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
    }

    public void OnSelected()
    {
        if (!isClose)
        {
            // Set the new target position in front of the camera
            targetPosition = playerCamera.position + playerCamera.forward * moveDistance;
            isClose = true;

            if (crunchAudio != null)
            {
                crunchAudio.Play();
            }
            // Hide burger and respawn later
            StartCoroutine(HideAndRespawn());
        }
        
        else
        {
            // Set the target back to original position
            targetPosition = originalPosition;
            isClose = false;
        }
        
    }
    private IEnumerator HideAndRespawn()
    {
        // Wait for the crunch sound to finish (optional small delay)
        yield return new WaitForSeconds(5.5f);

        // Hide burger
        gameObject.SetActive(false);

        // Wait for respawn delay
        yield return new WaitForSeconds(respawnDelay);

        // Reset position and rotation
        transform.position = originalPosition;
        isClose = false;

        // Show burger again
        gameObject.SetActive(true);
    }

}
    

