using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{
    public delegate void NewCubeSpawned();
    public static event NewCubeSpawned NewCubeSpawnedEvent;

    [Header("Base cube")]
    [SerializeField] private GameObject _cubePrefab;


    private void SpawnCube()
    {
        StartCoroutine(SpawnCubeCoroutine());
    }


    IEnumerator SpawnCubeCoroutine()
    {
        yield return new WaitForSeconds(1.25f);
        Instantiate(_cubePrefab, transform.position, transform.rotation);
        NewCubeSpawnedEvent?.Invoke();
    }
}