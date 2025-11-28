using UnityEngine;
using UnityEngine.UI;

public class CollectableSaver : MonoBehaviour
{
    [SerializeField] private Image _img;

    public void OnCollectableObtained()
    {
        string id = _img.sprite.name;

        bool alreadyCollected = PlayerPrefs.GetInt("collected_" + id, 0) == 1;

        if (!alreadyCollected)
        {
            PlayerPrefs.SetInt("collected_" + id, 1);
            Notification.instance.ShowNotification();
        }
    }
}
