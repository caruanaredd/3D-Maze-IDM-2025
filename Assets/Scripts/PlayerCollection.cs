using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    // This script will remove collectables from
    // the scene when the player hits them
    private void OnTriggerEnter(Collider other)
    {
        // check that we hit a collectable
        if (other.CompareTag("Collectable"))
        {
            Debug.Log($"Collided with {other.name}");
            Destroy(other.gameObject);
        }
    }
}
