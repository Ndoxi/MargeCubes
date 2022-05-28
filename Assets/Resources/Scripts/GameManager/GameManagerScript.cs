using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManagerScript : MonoBehaviour
{
    [Header("Cube materials")]
    [SerializeField] private CubeLevels _cubeLevels;

    [Header("UI Manager")]
    [SerializeField] private UIManagerScript _UIManager;

    public static List<Material> LevelMaterials { get { return Instance._cubeLevels.CubeMaterials; } }
    public static GameManagerScript Instance;

    private int _playerScore;


    private void OnEnable()
    {
        Instance = this;
    }


    public static void AddScoreToPlayer(int scoreAmount)
    {
        Instance._playerScore += scoreAmount;
        Instance._UIManager.SetPlayerScoreUI(Instance._playerScore.ToString());
    }
}