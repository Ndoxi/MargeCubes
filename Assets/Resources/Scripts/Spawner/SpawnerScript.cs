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
    /// Spawn cube
    /// </summary>
    private void SpawnCube()
    {
        StartCoroutine(SpawnCubeCoroutine());
    }


    /// <summary>
    /// Spawn cube after 1.25s, set it random level [1, 3] and material
    /// </summary>
    /// <returns></returns>
    IEnumerator SpawnCubeCoroutine()
    {
        yield return new WaitForSeconds(1.25f);
        GameObject newCube = Instantiate(_cubePrefab, transform.position, transform.rotation);
        int randomNum = RandomNumber();
        CubeScriptManager cubeScriptManager = newCube.GetComponent<CubeScriptManager>();
        cubeScriptManager.Cube.SetCubeStats(randomNum);

        NewCubeSpawnedEvent?.Invoke(newCube);
    }


    /// <summary>
    /// Ganarates random number in range [1, 3]. 65% - 1, 25% - 2, 10% - 2
    /// </summary>
    /// <returns></returns>
    private int RandomNumber()
    {
        int randomNum = Random.Range(0, 1000); 

        if (randomNum <= 649)
        {
            return 1;
        }

        if (649 < randomNum && randomNum <= 899)
        {
            return 2;
        }

        return 3;
    }
}