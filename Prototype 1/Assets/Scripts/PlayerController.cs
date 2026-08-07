using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in Inspector)
    public float speed = 5.0f;
    public float turnSpeed = 5f;
    // Input System action exposed in Inspector for binding (WASD/Arrow keys)
    public InputAction MoveAction;

    // Current input value (x = left/right, y = forward/back), kept private for internal use
    private Vector2 moveInput;

    void Start()
    {
        // Enable the MoveAction so it starts reading input
        MoveAction.Enable();
    }

    void Update()
    {
        // Read the 2D vector from the MoveAction (x: horizontal, y: vertical)
        moveInput = MoveAction.ReadValue<Vector2>();

        // Move forward/back along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate around local Y (yaw) using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x * moveInput.y);
    }
}