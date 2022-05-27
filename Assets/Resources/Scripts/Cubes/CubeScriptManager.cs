using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeScriptManager : MonoBehaviour
{
    [Header("Cube controls")]
    [SerializeField] private CubeControls _cubeControls;

    [Header("Cube stats script")]
    [SerializeField] private CubeScript _cubeScript;

    [Header("Cube behavior")]
    [SerializeField] private CubeBehavior _behavior;

    [Header("Cube physics")]
    [SerializeField] private CubePhysics _cubePhysics;

    [Header("Colision handler")]
    [SerializeField] private CubeColisionHandler _colisionHandler;

    public CubeControls Controls { get { return _cubeControls; } }
    public CubeScript Cube { get { return _cubeScript; } }
    public CubeBehavior Behavior { get { return _behavior; } }
    public CubePhysics CubePhysics { get { return _cubePhysics; } }
    public CubeColisionHandler ColisionHandler { get { return _colisionHandler; } }
}