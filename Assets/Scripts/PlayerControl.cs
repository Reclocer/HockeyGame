using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //[SerializeField] private Collider2D _playerPlayZone;    
    private Vector2 _transformPosition;
    private Rigidbody2D _rigidbody2D;    
    [SerializeField] private int _stickSense = 10;
    private IUserControl _userControl; 

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _userControl = GetComponent<IUserControl>();
        //Cursor.visible = false;
    }
    
    void Update()
    {        
        
    }    

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = (_userControl.CursorPosition - transform.position) * _stickSense; // оптимизировать?
    }  
    
    /// <summary>
    /// Sinleton - Set control system
    /// </summary>
    /// <param name="userControl"></param>
    private void SetControl(IUserControl userControl)
    {
        if(_userControl != null)
        {
            Destroy(_userControl.Component);
        }

        _userControl = userControl;
    }
}
