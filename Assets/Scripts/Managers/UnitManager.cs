using UnityEngine;

public class UnitManager : StaticInstance<UnitManager> {

    public void SpawnHeroes() {
        // SpawnUnit(PlayerType.Tarodev, new Vector3(1, 0, 0));
    }

    void SpawnUnit(PlayerType t, Vector3 pos) {
        // var tarodevScriptable = ResourceSystem.Instance.GetExampleHero(t);

        // var spawned = Instantiate(tarodevScriptable.Prefab, pos, Quaternion.identity,transform);

        // Apply possible modifications here such as potion boosts, team synergies, etc
        // var stats = tarodevScriptable.BaseStats;
        // stats.Health += 20;

        // spawned.SetStats(stats);
    }
}