using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRoomContent : MonoBehaviour
{
    [SerializeField] private Image _roomImage;
    [SerializeField] private TMP_Text _roomText;

    public void UpdateRoom(RoomContent room)
    {
        _roomImage.sprite = room._roomSprite;
        _roomText.text = room._description;
    }
}
