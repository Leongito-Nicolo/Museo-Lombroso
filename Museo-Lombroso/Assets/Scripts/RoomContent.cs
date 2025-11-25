using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "RoomContent", menuName = "Scriptable Objects/RoomContent")]
public class RoomContent : ScriptableObject
{
    public GameObject _roomPrefab;
    public LocalizedString _description;
}
