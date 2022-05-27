using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeControls : MonoBehaviour
{
    [Header("Cube rigidbody")]
    [SerializeField] private Rigidbody _rigidbody;

    [Header("Aim sensitivity")]
    [SerializeField] private float _aimSensitivity = 0.01f;

    [Header("Fire force")]
    [SerializeField] private float _fireForce = 3.5f;

    [Header("Position limits")]
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;


    public void AimCube(float xMove)
    {
        //_rigidbody.velocity = new Vector3(
        //    Mathf.Clamp(xMove * _aimSensitivity, -50 , 50), 
        //    _rigidbody.velocity.y, 
        //    _rigidbody.velocity.z);

        _rigidbody.position = new Vector3(
             Mathf.Clamp(_rigidbody.position.x + xMove * _aimSensitivity, _minX, _maxX),
            _rigidbody.position.y,
            _rigidbody.position.z);
    }


    public void FireCube()
    {
        Vector3 force = new Vector3(0, 0, _fireForce);
        _rigidbody.AddForce(force, ForceMode.Impulse);
    }
}
