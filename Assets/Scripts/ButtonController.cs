using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Keep button position in front of the camera
    void LateUpdate()
    {
        Transform cam = Camera.main.transform;

        Vector3 targetPosition = cam.position;
        targetPosition.y = transform.position.y;

        transform.LookAt(targetPosition);

    }
}
