using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeControls : MonoBehaviour
{
    public delegate void CubeWasFired();
    public static event CubeWasFired FireCubeEvent;

    [Header("Cube script manager")]
    [SerializeField] private CubeScriptManager _scriptManager;

    [Header("Aim sensitivity")]
    [SerializeField] private float _aimSensitivity = 0.01f;

    [Header("Position limits")]
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
        

    public void AimCube(float xMove)
    {
        Rigidbody cubeRigidBody = _scriptManager.CubePhysics.Rigidbody;

        _scriptManager.CubePhysics.Rigidbody.position = new Vector3(
             Mathf.Clamp(cubeRigidBody.position.x + xMove * _aimSensitivity, _minX, _maxX),
             cubeRigidBody.position.y,
             cubeRigidBody.position.z);
    }


    public void FireCube()
    {
        Vector3 force = new Vector3(0, 0, _scriptManager.CubePhysics.FireForce);
        _scriptManager.CubePhysics.Rigidbody.AddForce(force, ForceMode.Impulse);
        FireCubeEvent?.Invoke();
    }


    public void Jump()
    {
        Vector3 force = new Vector3(0, _scriptManager.CubePhysics.FireForce / 5, 0);
        _scriptManager.CubePhysics.Rigidbody.AddForce(force, ForceMode.Impulse);
    }
}