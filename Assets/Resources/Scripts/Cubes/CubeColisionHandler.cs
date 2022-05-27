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

        if (_scriptManager.CubePhysics.Velocity < cubeScriptManager.CubePhysics.Velocity)
        {
            //Destroy cube with lesser velicity 
            Destroy(gameObject);
        } 
        else
        {
            //Launch in air cube with greater velocity 
            _scriptManager.Controls.Jump();
        }
    }
}