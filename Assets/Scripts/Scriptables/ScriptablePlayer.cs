using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player")]
public class ScriptablePlayer : ScriptableUnitBase{
    public PlayerType playerType;
}

[Serializable]
public enum PlayerType{
    Player1,
    Player2
}