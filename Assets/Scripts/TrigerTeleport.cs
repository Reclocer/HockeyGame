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

    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == _puck)
        {
            // оптимизировать!!! (Puck.GoToStartPosition())
            //_puck.transform.position = _puckStartPosition.position;
            //_puck.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //_puck.GetComponent<Rigidbody2D>().angularVelocity = 0;

            OnTriggerTeleportEnter(_redGate);
        }
    }
}
