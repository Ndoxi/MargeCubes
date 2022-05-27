using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubePhysics : MonoBehaviour
{
    [Header("Cube rigidbody")]
    [SerializeField] private Rigidbody _rigidbody;

    [Header("Fire force")]
    [SerializeField] private float _fireForce = 30;

    public Rigidbody Rigidbody { get { return _rigidbody; } }
    public float FireForce { get { return _fireForce; } }
    public float Velocity { get { return _rigidbody.velocity.magnitude; } }
}
