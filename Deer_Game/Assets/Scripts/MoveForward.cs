using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    // Define the speed at which the object moves forward
    public float speed = 40.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward based on the speed and time elapsed since the last frame
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
