using UnityEngine;

public class LookAround : MonoBehaviour
{
    /// <summary>
    /// Speed of the rotation.
    /// </summary>
    public float speed = 3;

    /// <summary>
    /// image to make black transition when changing room.
    /// </summary>
    public GameObject imageBackground;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Camera movement
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));

            // Image movement for beeing always in front of the camera
            imageBackground.transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            imageBackground.transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
        }
    }
}
