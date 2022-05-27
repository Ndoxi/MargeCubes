using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScriptManager : MonoBehaviour
{
    [Header("Input handler")]
    [SerializeField] private InputHandler _inputHandler;

    [Header("Gameplay script")]
    [SerializeField] private Gameplay _gameplay;

    public InputHandler InputHandler { get { return _inputHandler; } }
    public Gameplay Gameplay { get { return _gameplay; } }
}
