using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuButtons : MonoBehaviour
{
    [Header("Play button")]
    [SerializeField] private Button _playBytton;

    [Header("LoadingProgressElement")]
    [SerializeField] private GameObject _loadingProgressElement;

    [Header("Slider")]
    [SerializeField] private Slider _progressBar;

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
        StartCoroutine(LoadGameCoroutine());
    }


    private IEnumerator LoadGameCoroutine()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync(_mainSceneIndex);
        _loadingProgressElement.SetActive(true);

        while (true)
        {
            _progressBar.value = loading.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
