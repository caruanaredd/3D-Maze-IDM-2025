using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    // This is a comment and will be ignored
    // by Unity.
    
    // Basic variables for our player
    public string heroName = "Capsule Kid";
    public int health = 100;
    public float speed = 5.5f;
    public bool isAlive = true;

    // In which direction the player will move
    private Vector3 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"My name is {heroName}!");
    }

    // Update is called once per frame
    void Update()
    {
        // Keyword - transform
        transform.Translate(direction * Time.deltaTime * speed);
    }

    // Will trigger when the player presses
    // WASD or the arrow keys
    private void OnMove(InputValue value)
    {
        // reading the player's input
        Vector2 input = value.Get<Vector2>();
        direction = new Vector3(input.x, 0, input.y);
    }
}
