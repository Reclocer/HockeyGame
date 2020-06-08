using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string _playerName = "New Player";

    private void Start()
    {
        UIManager.Instance.SetPlayerName(_playerName);
    }
}
