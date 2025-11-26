using UnityEngine;
using UnityEngine.UI;

public class ActivateCollectable : MonoBehaviour
{
    public Image icon;

    void Start()
    {
        string id = icon.sprite.name;

        bool collected = PlayerPrefs.GetInt("collected_" + id, 0) == 1;

        gameObject.SetActive(collected);
    }
}
