using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody fireballRb;
    public float speed = 5;
    public float lifetime = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireballRb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, lifetime);
    }
}
