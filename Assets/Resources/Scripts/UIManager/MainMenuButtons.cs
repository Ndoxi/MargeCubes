using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuButtons : MonoBehaviour
{
    [Header("Play button")]
    [SerializeField] private Button _playBytton;

    private const int _mainSceneIndex = 1;


    private void OnEnable()
    {
        _playBytton.onClick.AddListener(StartGame);
    }


    private void OnDisable()
    {
        _playBytton.onClick.RemoveListener(StartGame);
    }


    private void StartGame()
    {
        SceneManager.LoadScene(_mainSceneIndex);
    }
}
