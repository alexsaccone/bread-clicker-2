using UnityEngine;

public class stickToLeftCenter : MonoBehaviour
{
    public float yOffset = 0f;
    public float pixelsPerUnit = 32f;

    void LateUpdate()
    {
        Camera cam = Camera.main;

        float camHeight = cam.orthographicSize * 2f;
        float camWidth = camHeight * cam.aspect;

        float leftEdge = cam.transform.position.x - camWidth / 2f;
        float center = cam.transform.position.x;
        float halfwayX = (leftEdge + center) / 2f;

        float y = cam.transform.position.y + yOffset;

        Vector3 pos = new Vector3(halfwayX, y, transform.position.z);

        // 🔧 Snap to pixel grid
        pos.x = Mathf.Round(pos.x * pixelsPerUnit) / pixelsPerUnit;
        pos.y = Mathf.Round(pos.y * pixelsPerUnit) / pixelsPerUnit;

        transform.position = pos;
    }
}
