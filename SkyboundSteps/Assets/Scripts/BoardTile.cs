using UnityEngine;

public enum TileEffectType
{
    None,
    MoveForward,
    MoveBackward
}

public class BoardTile : MonoBehaviour
{
    public int tileIndex;
    public TileEffectType effectType;
    public int effectAmount;
    public Transform snapPoint;
}
