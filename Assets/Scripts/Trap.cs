using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Killing {other.gameObject}");
        Destroy(other.gameObject);
    }
}
