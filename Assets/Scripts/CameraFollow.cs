using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // To follow the player,
    // use the Transform component
    public Transform target;
    public float followSpeed = 5;

    // The distance from the target
    private Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculates the distance between the camera
        // and its target
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // If the target is destroyed,
        // we will disable the script
        if (target == null)
        {
            enabled = false;
            return; // stop here
        }

        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            followSpeed * Time.deltaTime);
    }
}
