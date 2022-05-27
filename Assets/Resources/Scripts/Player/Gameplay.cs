using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gameplay : MonoBehaviour
{
    [Header("Player script manager")]
    [SerializeField] private PlayerScriptManager _scriptManager;

    private CubeControls _cubeControls;


    private void OnEnable()
    {
        SpawnerScript.NewCubeSpawnedEvent += SetNewCubeToFire;
        CubeControls.FireCubeEvent += ClearCurrentCubeData;
    }


    private void OnDisable()
    {
        SpawnerScript.NewCubeSpawnedEvent -= SetNewCubeToFire;
        CubeControls.FireCubeEvent -= ClearCurrentCubeData;
    }


    public void AimCube()
    {
        if (_cubeControls == null) { return; }

        _cubeControls.AimCube(_scriptManager.InputHandler.TuchDeltaX);
    }


    public void FireCube()
    {
        if (_cubeControls == null) { return; }

        _cubeControls.FireCube();
    }



    public void SetNewCubeToFire(GameObject newCube)
    {
        _cubeControls = newCube.GetComponent<CubeScriptManager>().Controls;
    }


    public void ClearCurrentCubeData()
    {
        _cubeControls = null;
    }
}