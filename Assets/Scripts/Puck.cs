using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Puck : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    public Rigidbody2D Rigidbody => _rigidBody;

    [SerializeField] private Gate _blueGate;
    [SerializeField] private Gate _redGate = new Gate();

    [SerializeField] private Transform _puckStartPositionBlue;
    [SerializeField] private Transform _puckStartPositionRed;
    [SerializeField] private TrigerTeleport[] _trigerTeleports;
    

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _blueGate.OnGoal += GoToStartPosition;
        _redGate.OnGoal += GoToStartPosition;
        
        for(int i = 0; i < _trigerTeleports.Length; i++)
        {
            _trigerTeleports[i].OnTriggerTeleportEnter += GoToStartPosition;
        }
    }   

    private void GoToStartPosition(Gate onGoalGate)
    {
        transform.position = onGoalGate.PuckStartPosition.position;
        _rigidBody.velocity = Vector2.zero;
        _rigidBody.angularVelocity = 0;
    }

    #region Custom Inspector
    [ContextMenu("Show Rb Info")] //даем возможность вызывать метод из инспектора
    public void ShowRbInfo()
    {
        Debug.Log($"Rb velocity of Puck: {_rigidBody.velocity}");
    }

    [ContextMenu("Self destroy XXX")]
    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
    #endregion
}
