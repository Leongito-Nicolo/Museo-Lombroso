using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

public class ButtonTextChanger : MonoBehaviour
{
    public LocalizedString _objectDescription;

    public void OnButtonPressed(LocalizeStringEvent target)
    {

        target.StringReference = _objectDescription;

    }
}
