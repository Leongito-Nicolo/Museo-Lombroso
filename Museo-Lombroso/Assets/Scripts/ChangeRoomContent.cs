using UnityEngine;
using UnityEngine.Localization.PropertyVariants;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;

public class ChangeRoomContent : MonoBehaviour
{
    [SerializeField] private GameObject _roomContainer;
    // [SerializeField] private LocalizeStringEvent _roomText;
    [SerializeField] private GameObjectLocalizer _localizer;

    public void UpdateRoom(RoomContent room)
    {
        var roomObj = Instantiate(room._roomPrefab, _roomContainer.transform);

        // _roomText.StringReference = room._description;
        var trackedObj = _localizer.TrackedObjects[0];

        if (trackedObj.TrackedProperties[0] is LocalizedStringProperty trackedProp)
        {
            trackedProp.LocalizedString = room._description;
        }

        roomObj.GetComponent<HighlightObject>().Init(_localizer);
    }

    public void DestroyRoom(GameObject roomContainer)
    {
        Destroy(roomContainer.transform.GetChild(0).gameObject);
    }

    [ContextMenu("test")]
    public void Test()
    {
        Debug.Log(((LocalizedStringProperty)_localizer.TrackedObjects[0].TrackedProperties[0]).LocalizedString);
    }
}
