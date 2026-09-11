using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Define the lower and upper bounds for the object's position along the z-axis
    public float lowerBound = -10.0f;
    public float upperBound = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the object's position exceeds the defined bounds and destroy it if it does
        if (transform.position.z > upperBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
