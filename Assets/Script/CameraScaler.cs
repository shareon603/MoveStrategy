using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraScaler : MonoBehaviour
{
    public float targetWidth = 1920f;
    public float targetHeight = 1080f;
    public float fixedOrthographicSize = 5f;

    void Start()
    {
        Camera cam = GetComponent<Camera>();
        cam.orthographicSize = fixedOrthographicSize;

        float targetAspect = targetWidth / targetHeight;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scale = windowAspect / targetAspect;

        if (scale < 1f)
        {
            // ȭ���� ���η� �� ŭ �� ���� ���� �ʿ� (Letterbox)
            Rect rect = new Rect();
            rect.width = 1f;
            rect.height = scale;
            rect.x = 0f;
            rect.y = (1f - scale) / 2f;
            cam.rect = rect;
        }
        else
        {
            // ȭ���� ���η� �� ŭ �� �¿� ���� �ʿ� (Pillarbox)
            float scaleWidth = 1f / scale;
            Rect rect = new Rect();
            rect.width = scaleWidth;
            rect.height = 1f;
            rect.x = (1f - scaleWidth) / 2f;
            rect.y = 0f;
            cam.rect = rect;
        }
    }
}
