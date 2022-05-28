using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeColisionHandler : MonoBehaviour
{
    [Header("Script manager")]
    [SerializeField] private CubeScriptManager _scriptManager;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != gameObject.layer) { return; }

        GameObject collisionGO = collision.gameObject;
        CubeScriptManager cubeScriptManager = collisionGO.GetComponent<CubeScriptManager>();

        if (_scriptManager.Behavior.CubeLevel != cubeScriptManager.Behavior.CubeLevel) { return; }

        if (_scriptManager.CubePhysics.Velocity >= cubeScriptManager.CubePhysics.Velocity)
        {
            //Destroy cube with greater velicity and add player score
            GameManagerScript.AddScoreToPlayer(_scriptManager.Behavior.CubeValue * 2);
            Destroy(gameObject);
        } 
        else
        {
            //Launch in air cube with lesser velocity and level up it
            _scriptManager.Controls.LaunchCubeInAir();
            _scriptManager.Cube.LevelUpCube();
        }
    }
}