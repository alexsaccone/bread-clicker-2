using UnityEngine;

public class changeSpritePositions : MonoBehaviour
{
    public float yOffset = 0.5f; // distance from top edge in world units


    void LateUpdate()
    {
        Camera cam = Camera.main;
        float camHeight = cam.orthographicSize * 2f;
        float topY = cam.transform.position.y + camHeight / 2f;

        Vector3 pos = transform.position;
        pos.y = topY - yOffset;
        transform.position = pos;
    }
}
