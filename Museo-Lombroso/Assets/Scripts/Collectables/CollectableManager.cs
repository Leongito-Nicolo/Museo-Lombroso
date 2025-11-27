using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;
    [SerializeField] private GameObject _achievement;
    public static CollectableManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public bool AllCollectablesObtained()
    {
        foreach (var item in _sprites)
        {
            string id = item.name;

            if (PlayerPrefs.GetInt("collected_" + id, 0) != 1)
            {
                return false;
            }
        }

        return true;
    }

    public void ObtainAchievement()
    {
        if (AllCollectablesObtained())
        {
            Debug.Log("bravo");
            PlayerPrefs.SetInt("achievement", 1);
            _achievement.SetActive(true);
        }
    }


}