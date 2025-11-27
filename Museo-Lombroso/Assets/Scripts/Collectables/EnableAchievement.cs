using UnityEngine;

public class EnableAchievement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("achievement") != 1)
        {
            gameObject.SetActive(false);
        }
    }
}
