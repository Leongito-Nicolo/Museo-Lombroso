using System.Collections;
using UnityEngine;

public class Notification : MonoBehaviour
{
    public static Notification instance;

    [Header("Animation Settings")]
    public Vector2 offscreenPosition;
    public Vector2 onscreenPosition;
    public float moveDuration = 0.5f;
    public float visibleDuration = 1.0f;

    private RectTransform rect;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        rect = GetComponent<RectTransform>();
        rect.anchoredPosition = offscreenPosition;
    }

    public void ShowNotification()
    {
        gameObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(AnimateNotification());
    }

    private IEnumerator AnimateNotification()
    {
        yield return Move(rect.anchoredPosition, onscreenPosition, moveDuration);

        yield return new WaitForSeconds(visibleDuration);

        yield return Move(rect.anchoredPosition, offscreenPosition, moveDuration);
    }

    private IEnumerator Move(Vector2 start, Vector2 end, float duration)
    {
        float t = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            float normalized = Mathf.Clamp01(t / duration);
            rect.anchoredPosition = Vector2.Lerp(start, end, normalized);
            yield return null;
        }

        rect.anchoredPosition = end;
    }
}
