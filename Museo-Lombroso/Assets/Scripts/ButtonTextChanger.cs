using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.PropertyVariants;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class ButtonTextChanger : MonoBehaviour
{
    public LocalizedString _objectDescription;

    public void OnButtonPressed(GameObjectLocalizer target)
    {
        var trackedObj = target.TrackedObjects[0];

        if (trackedObj.TrackedProperties[0] is LocalizedStringProperty trackedProp)
        {
            trackedProp.LocalizedString = _objectDescription;
        }
    }
}
