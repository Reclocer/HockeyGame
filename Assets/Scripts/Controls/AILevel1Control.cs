using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILevel1Control : AbstractStickControl
{
    private void Start()
    {
        _targetPosition = transform.position;
    }

    public override void MoveTargetPositionForStick()
    {
        _targetPosition.x = _puck.transform.position.x;

        if (_playZone.IsOutOfBounds(_targetPosition))
        {
            return;
        }

        _cursorPosition = _targetPosition;
    }
}
