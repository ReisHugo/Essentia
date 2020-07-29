using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform characterPosition;
    public float smoothnessSpeed = 0.05f;
    public Vector3 offsetPosition;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = characterPosition.position + offsetPosition;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothnessSpeed);
        transform.position = smoothedPosition;
        //transform.LookAt(target);
    }
}