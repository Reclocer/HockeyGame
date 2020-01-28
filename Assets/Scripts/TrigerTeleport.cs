using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerTeleport : MonoBehaviour
{
    [SerializeField] private Transform _puckStartPosition;
    [SerializeField] private Collider2D _puck;
    [SerializeField] private Gate _redGate;
    public event Action<Gate> OnTriggerTeleportEnter = (gate) => { };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == _puck)
        {          
            OnTriggerTeleportEnter(_redGate);
        }
    }
}
