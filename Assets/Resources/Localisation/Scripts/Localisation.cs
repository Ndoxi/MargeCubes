using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class Localisation : MonoBehaviour
{
    [Header("Button text")]
    [SerializeField] private TextMeshProUGUI _buttonText;

    [Header("JSON files")]
    [SerializeField] private TextAsset _jsonEN;
    [SerializeField] private TextAsset _jsonRU;

    public enum Language { EN = 0, RU = 1 }

    private MainMenuText _mainMenuText;


    /// <summary>
    /// Get main menu text
    /// </summary>
    /// <param name="language">Language of text</param>
    /// <returns>Class that containt all text</returns>
    private MainMenuText ReadJSON(Language language)
    {
        switch (language)
        {
            case Language.EN :
            {
                return JsonUtility.FromJson<MainMenuText>(_jsonEN.text);
            }

            case Language.RU :
            {
                return JsonUtility.FromJson<MainMenuText>(_jsonRU.text);
            }
        }

        return JsonUtility.FromJson<MainMenuText>(_jsonEN.text);
    }


    public void LoadMenuText(Language language)
    {
        _mainMenuText = ReadJSON(language);
        _buttonText.text = _mainMenuText.MainMunuButtonText;
    }
}