using UnityEngine;

[CreateAssetMenu(fileName = "RoomContent", menuName = "Scriptable Objects/RoomContent")]
public class RoomContent : ScriptableObject
{
    public Sprite _roomSprite;
    [TextArea(6, 4)] public string _description;
}
