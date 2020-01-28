using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILevel2Control : AbstractStickControl
{
    [SerializeField] private Transform _puckStartPositionRed;
    [SerializeField] private Gate _redGate;
    private Stick _stick;
    private Vector2 _stickStartPosition;
    [SerializeField] private float _verticalStickSense = 2;
    [SerializeField] private TrigerTeleport[] _trigerTeleports;

    private void Start()
    {
        _stick = GetComponent<Stick>();
        _stickStartPosition = _stick.transform.position;
        _targetPosition = transform.position;
        _redGate.OnGoal += metod => { ZeroTargetPosition(); };
        for (int i = 0; i < _trigerTeleports.Length; i++)
        {
            _trigerTeleports[i].OnTriggerTeleportEnter += metod => { ZeroTargetPosition(); };
        }
    }

    public override void MoveTargetPositionForStick()
    {
        Vector3 puckTransformPosition = _puck.transform.position;

        if (puckTransformPosition.y >= transform.position.y && (transform.position.x < -0.5f || transform.position.x > 0.5f) )
        {
            if (_playZone.IsOutOfBounds(_targetPosition))
            {
                _targetPosition.y = transform.position.y + _verticalStickSense;
            }
        }
        else if (_playZone.IsOutOfBounds(_targetPosition))
        {            
            _targetPosition.y = transform.position.y - _verticalStickSense;           
        }

        _targetPosition.x = puckTransformPosition.x;
        
        if (_playZone.IsOutOfBounds(_targetPosition))
        {
            return;
        }

        _cursorPosition = _targetPosition;        
    }

    private void ZeroTargetPosition()
    {
        _targetPosition = _puckStartPositionRed.position;
    }
}
