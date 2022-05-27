using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeScript : MonoBehaviour
{
    [Header("Script manager")]
    [SerializeField] private CubeScriptManager _scriptManager;

    [Header("Cube renderer")]
    [SerializeField] private Renderer _cubeRenderer;

    [Header("Cube TMPros")]
    [SerializeField] private List<TextMeshPro> _textMeshPros;


    public void SetCubeStats(int cubeLevel, Material cubeMaterial)
    {
        float cubeValue = Mathf.Pow(2, cubeLevel);

        _scriptManager.Behavior.CubeLevel = cubeLevel;
        _cubeRenderer.material = cubeMaterial;

        foreach (TextMeshPro textMeshPro in _textMeshPros)
        {
            textMeshPro.text = ((int)cubeValue).ToString();
        }
    }
}