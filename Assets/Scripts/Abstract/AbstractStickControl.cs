using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Stick))]
public abstract class AbstractStickControl : MonoBehaviour, IUserControl
{
    [SerializeField] protected PlayZone _playZone;
    [SerializeField] protected Puck _puck;
    protected Vector3 _cursorPosition;
    public Vector3 CursorPosition => _cursorPosition;
    public Object Component => this;
    protected Vector3 _targetPosition;

    public virtual void Update()
    {
        MoveTargetPositionForStick();
    }

    public abstract void MoveTargetPositionForStick();  
}
