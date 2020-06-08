using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{       
    private Vector2 _transformPosition;
    private Vector2 _startPosition;
    private Rigidbody2D _rigidbody;
    [SerializeField] private int _stickSense = 12;
    private IUserControl _userControl;

    void Start()
    {
        _startPosition = transform.position;
        _rigidbody = GetComponent<Rigidbody2D>();
        _userControl = GetComponent<IUserControl>();
        //Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = (_userControl.CursorPosition - transform.position) * _stickSense; // оптимизировать?
    }

    /// <summary>
    /// Set stick control system
    /// </summary>
    /// <param name="userControl"></param>
    private void SetControl(IUserControl userControl)
    {
        if (_userControl != null)
        {
            Destroy(_userControl.Component);
        }

        _userControl = userControl;
    }

    public void GoToStartPosition()
    {
        transform.position = _startPosition;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0;
    }
}
