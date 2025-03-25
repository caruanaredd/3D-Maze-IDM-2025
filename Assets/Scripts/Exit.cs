using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            winScreen.SetActive(true);
        }
    }
}
