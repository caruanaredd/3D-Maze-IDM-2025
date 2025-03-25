using System.Collections;
using UnityEngine;

public class FireballShooter : MonoBehaviour
{
    public GameObject fireball;
    public float timer = 2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnFireballRoutine());
    }

    private IEnumerator SpawnFireballRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);
            Instantiate(fireball, transform.position, transform.rotation);
        }
    }
}
