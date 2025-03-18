using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPoint;
    public TMP_Text healthText;

    public GameObject gameOverScreen;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Registers the player's starting position
        respawnPoint = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }

        if (other.CompareTag("Checkpoint"))
        {
            respawnPoint = other.transform.position;
            respawnPoint.y = transform.position.y;
        }
    }

    /// <summary>
    /// Reduces points from the health.
    /// </summary>
    /// <param name="value">The number of points to reduce.</param>
    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"<b>Health:</b> {points}";
        
        transform.position = respawnPoint;
        
        // For now, fix later
        if (points < 1)
        {
            gameOverScreen.SetActive(true);
            Destroy(gameObject);
        }
    }
}
