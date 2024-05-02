using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform cameraTransform;
    public float parallaxFactor = 0.5f; // Between 0 and 1

    private Vector3 previousCameraPosition;
    private bool initialFrame = true;

    void Update()
    {
        if (initialFrame)
        {
            previousCameraPosition = cameraTransform.position;
            initialFrame = false;
            return;
        }

        Vector3 deltaMovement = cameraTransform.position - previousCameraPosition;
        // Ensure parallaxFactor is within the bounds
        parallaxFactor = Mathf.Clamp(parallaxFactor, 0f, 1f);
        // Apply the parallax effect based on the camera's movement and the parallax factor
        transform.position += new Vector3(deltaMovement.x * parallaxFactor, deltaMovement.y * parallaxFactor, 0);
        previousCameraPosition = cameraTransform.position;
    }
}
