using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private int _cubeLevel;
    private int _cubeValue;

    public int CubeLevel { get { return _cubeLevel; } 
            set {
            _cubeValue = (int)Mathf.Pow(2, value);
            _cubeLevel = value; } }

    public int CubeValue { get { return _cubeValue; }}
}
