using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Stick))]
public class MouseControl : MonoBehaviour, IUserControl
{
    [SerializeField] private PlayZone _playZone;

    private Vector3 _cursorPosition;
    public Vector3 CursorPosition => _cursorPosition;
    public Object Component => this;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        MoveStickWithCursor();
    }

    private void MoveStickWithCursor()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (_playZone.IsOutOfBounds(mousePos))
            return;

        _cursorPosition = mousePos;
    }    
}
