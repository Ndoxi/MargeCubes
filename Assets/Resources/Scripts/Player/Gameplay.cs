using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gameplay : MonoBehaviour
{
    [Header("Player script manager")]
    [SerializeField] private PlayerScriptManager _scriptManager;

    [Header("Cube to fire")]
    [SerializeField] private GameObject _cube;

    private CubeControls _cubeControls;


    private void Start()
    {
        SetNewCubeToFire(_cube);
    }


    public void AimCube()
    {
        _cubeControls.AimCube(_scriptManager.InputHandler.TuchDeltaX);
    }


    public void FireCube()
    {
        _cubeControls.FireCube();
    }



    public void SetNewCubeToFire(GameObject newCube)
    {
        _cube = newCube;
        _cubeControls = newCube.GetComponent<CubeScriptManager>().Controls;
    }


    public void ClearCube()
    {
        _cube = null;
        _cubeControls = null;
    }
}