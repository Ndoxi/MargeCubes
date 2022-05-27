using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{
    public delegate void NewCubeSpawned(GameObject newCube);
    public static event NewCubeSpawned NewCubeSpawnedEvent;

    [Header("Base cube")]
    [SerializeField] private GameObject _cubePrefab;


    private void OnEnable()
    {
        CubeControls.FireCubeEvent += SpawnCube;
    }


    private void OnDisable()
    {
        CubeControls.FireCubeEvent -= SpawnCube;
    }


    private void Start()
    {
        SpawnCube();
    }


    /// <summary>
    /// Spawn cube and set it random level [1, 3]
    /// </summary>
    private void SpawnCube()
    {
        StartCoroutine(SpawnCubeCoroutine());
    }


    IEnumerator SpawnCubeCoroutine()
    {
        yield return new WaitForSeconds(1.25f);
        GameObject newCube = Instantiate(_cubePrefab, transform.position, transform.rotation);
        //CubeScriptManager cubeScriptManager = newCube.GetComponent<CubeScriptManager>();
        //cubeScriptManager.Cube.SetCubeStats();

        NewCubeSpawnedEvent?.Invoke(newCube);
    }
}