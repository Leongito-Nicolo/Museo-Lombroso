using UnityEngine;
using UnityEngine.UI;

public class CollectableSaver : MonoBehaviour
{
    [SerializeField] private Image _img;

    public void OnCollectableObtained()
    {
        string id = _img.sprite.name;
        PlayerPrefs.SetInt("collected_" + id, 1);
    }
}