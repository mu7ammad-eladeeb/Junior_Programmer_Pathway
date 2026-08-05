using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player; // Reference to the player GameObject
    private Vector3 offset = new Vector3(-0.01526528f, 11.34123f, -9.399508f); // Offset between the camera and the player
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Update the position of the camera to follow the player
        transform.position = player.transform.position + offset;
    }
}
