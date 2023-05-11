using System;
using UnityEngine;

public class ScriptableUnitBase : ScriptableObject {
    public Faction Faction;

    [SerializeField] private Stats _stats;
    public Stats BaseStat => _stats;

    public PlayerUnitBase Prefab;

    public string Description;
    public Sprite MenuSprite;
}

[Serializable]
public class Stats {
    public int Health;
    public int Attack;
    public int Speed;
}

[Serializable]
public enum Faction {
    Player = 0,
    Enemy = 1,
}
