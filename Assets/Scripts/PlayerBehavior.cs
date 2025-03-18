using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    // This is a comment and will be ignored
    // by Unity.
    
    // Basic variables for our player
    public string heroName = "Capsule Kid";
    public float speed = 5.5f;
    public float jumpForce = 5f;

    // In which direction the player will move
    public Vector3 direction;

    public Rigidbody playerRb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"My name is {heroName}!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Keyword - transform
        // transform.Translate(direction * Time.deltaTime * speed);
        
        // Use Rigidbody to move the player
        Vector3 velocity = direction * speed;
        
        // Lets the player fall normally
        velocity.y = playerRb.linearVelocity.y;
        
        playerRb.linearVelocity = velocity;
    }

    // Will trigger when the player presses
    // WASD or the arrow keys
    private void OnMove(InputValue value)
    {
        // reading the player's input
        Vector2 input = value.Get<Vector2>();
        direction = new Vector3(input.x, 0, input.y);
    }

    private void OnJump(InputValue value)
    {
        // Check if the player is standing on something
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);

        if (isGrounded)
        {
            // Push the player towards the sky
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
