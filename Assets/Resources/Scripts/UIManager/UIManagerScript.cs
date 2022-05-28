using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManagerScript : MonoBehaviour
{
    [Header("Player score text element")]
    [SerializeField] private TextMeshProUGUI _playerScore;


    public void SetPlayerScoreUI(string scoreText)
    {
        _playerScore.text = scoreText;
    }
}
