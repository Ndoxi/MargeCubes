using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeColisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != gameObject.layer) { return; }

        GameObject collisionGO = collision.gameObject;
    }
}
