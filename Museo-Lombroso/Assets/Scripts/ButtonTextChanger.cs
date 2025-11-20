using TMPro;
using UnityEngine;

public class ButtonTextChanger : MonoBehaviour
{

    [TextArea(6, 4)] public string _objectDescription;

    public void OnButtonPressed(TMP_Text target)
    {
        target.text = _objectDescription;
    }
}
