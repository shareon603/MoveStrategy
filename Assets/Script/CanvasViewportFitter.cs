using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class CanvasViewportFitter : MonoBehaviour
{
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        Camera cam = Camera.main;

        if (canvas.renderMode != RenderMode.ScreenSpaceCamera || cam == null)
            return;

        canvas.worldCamera = cam;
        canvas.planeDistance = 1;

        Rect viewport = cam.rect;

        RectTransform rt = canvas.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(viewport.x, viewport.y);
        rt.anchorMax = new Vector2(viewport.x + viewport.width, viewport.y + viewport.height);
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
    }
}
