using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : AbstractStickControl
{ 
    public override void MoveTargetPositionForStick()
    {
        _targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (_playZone.IsOutOfBounds(_targetPosition))
        {
            return;
        }

        _cursorPosition = _targetPosition;
    }    
}
