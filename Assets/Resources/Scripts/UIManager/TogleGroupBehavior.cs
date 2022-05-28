using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TogleGroupBehavior : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] private Toggle _toggleEN;
    [SerializeField] private Toggle _toggleRU;

    [Header("Localisation")]
    [SerializeField] private Localisation _localisation;


    private void Start()
    {
        LoadTextEN(true);
    }


    private void OnEnable()
    {
        _toggleEN.onValueChanged.AddListener(LoadTextEN);
        _toggleEN.onValueChanged.AddListener(LoadTextRU);
    }

    private void OnDisable()
    {
        _toggleEN.onValueChanged.RemoveListener(LoadTextEN);
        _toggleEN.onValueChanged.RemoveListener(LoadTextRU);
    }


    private void LoadTextEN(bool isOn)
    {
        if (_toggleEN.isOn == false) { return; }
        _localisation.LoadMenuText(Localisation.Language.EN);
    }


    private void LoadTextRU(bool isOn)
    {
        if (_toggleRU.isOn == false) { return; }
        _localisation.LoadMenuText(Localisation.Language.RU);
    }
}
