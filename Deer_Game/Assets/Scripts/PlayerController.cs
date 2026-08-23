using UnityEngine;
// This script uses the new Input System package in Unity to handle player movement input
using UnityEngine.InputSystem;
// This script controls the movement of the player character based on input from the user

public class PlayerController : MonoBehaviour
{
    // Variable to define the horizontal boundary for player movement
    public float horizontalBoundVariable = 20f;
    // Variable to define the lower vertical boundary for player movement
    public float lowerVerticalBoundVariable = 0.8346852f;
    // Variable to control the speed of the player movement
    // Variable to define the upper vertical boundary for player movement
    public float upperVerticalBoundVariable = 15f;
    public float speed = 10f;
    // Variable to store the input value for movement
    public Vector2 moveInput;
    public InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the moveAction to start receiving input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the input value from the moveAction and store it in moveInput
        moveInput = moveAction.ReadValue<Vector2>();
        // Move the player based on the input value horizontally
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        // Move the player based on the input value forward
        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed);
        // Clamp the player's position to stay within the defined horizontal and vertical boundaries
        if (transform.position.x > horizontalBoundVariable)
        {
            transform.position = new Vector3(horizontalBoundVariable, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -horizontalBoundVariable)
        {
            transform.position = new Vector3(-horizontalBoundVariable, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -lowerVerticalBoundVariable)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -lowerVerticalBoundVariable);
        }
        if (transform.position.z > upperVerticalBoundVariable)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, upperVerticalBoundVariable);
        }
    }
}
