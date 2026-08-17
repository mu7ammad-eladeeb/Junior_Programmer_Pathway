using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    public float speed = 10f; // Speed of the oncoming vehicle
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
