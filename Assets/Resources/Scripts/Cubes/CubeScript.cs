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


    public void SetCubeStats(int cubeLevel)
    {
        float cubeValue = Mathf.Pow(2, cubeLevel);

        _scriptManager.Behavior.CubeLevel = cubeLevel;

        if (cubeLevel > GameManagerScript.LevelMaterials.Count)
        {
            _cubeRenderer.material = GameManagerScript.LevelMaterials[-1];
        } 
        else
        {
            _cubeRenderer.material = GameManagerScript.LevelMaterials[cubeLevel - 1];
        }

        foreach (TextMeshPro textMeshPro in _textMeshPros)
        {
            textMeshPro.text = ((int)cubeValue).ToString();
        }
    }


    public void LevelUpCube()
    {
        int currentLevel = _scriptManager.Behavior.CubeLevel;
        int nextLevel = currentLevel + 1;
        _scriptManager.Behavior.CubeLevel = nextLevel;

        SetCubeStats(nextLevel);
    }
}