using System;
using UnityEngine;

public class GameManager : StaticInstance<GameManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }
    void Start() => ChangeState(GameState.Starting);

    public void ChangeState(GameState newState) {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState) {
            case GameState.Starting:
                HandleStarting();
                break;
            case GameState.SpawningHeroes:
                HandleSpawningHeroes();
                break;
            case GameState.SpawningEnemies:
                HandleSpawningEnemies();
                break;
            case GameState.PlayerTurn:
                HandlePlayerTurn();
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);
        
        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting() {
        
        ChangeState(GameState.SpawningHeroes);
    }

    private void HandleSpawningHeroes() {
        UnitManager.Instance.SpawnHeroes();
        
        ChangeState(GameState.SpawningEnemies);
    }

    private void HandleSpawningEnemies() {

        ChangeState(GameState.PlayerTurn);
    }

    private void HandlePlayerTurn() {

    }
}

[Serializable]
public enum GameState {
    Starting = 0,
    SpawningHeroes = 1,
    SpawningEnemies = 2,
    PlayerTurn = 3,
    EnemyTurn = 4,
    Win = 5,
    Lose = 6,
}
