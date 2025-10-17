using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset between the camera and the player
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
