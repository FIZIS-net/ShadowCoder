using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime = 0.125f;

    private Vector3 velocity;

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        targetPosition.z       = transform.position.z;
        transform.position     = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
