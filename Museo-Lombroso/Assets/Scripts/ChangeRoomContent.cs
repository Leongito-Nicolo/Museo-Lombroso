using TMPro;
using UnityEngine;

public class ChangeRoomContent : MonoBehaviour
{
    [SerializeField] private GameObject _roomContainer;
    [SerializeField] private TMP_Text _roomText;

    public void UpdateRoom(RoomContent room)
    {
        var roomObj = Instantiate(room._roomPrefab, _roomContainer.transform);

        _roomText.text = room._description;

        roomObj.GetComponent<HighlightObject>().Init(_roomText);
    }

    public void DestroyRoom(GameObject roomContainer)
    {
        Destroy(roomContainer.transform.GetChild(0).gameObject);
    }
}
