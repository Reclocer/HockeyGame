using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Stick))]
public class MouseControl : MonoBehaviour, IUserControl
{  
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
        //Ray rayCursor = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit2D hit;

        //if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0 && Physics2D.Raycast(rayCursor.origin, rayCursor.direction) == _playerPlayZone)
        //if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                
        //mousePosition.z = transform.position.z - Camera.main.transform.position.z; // это только для перспективной камеры необходимо
        _cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //положение мыши из экранных в мировые координаты
        //_playerStick.transform.position = mousePosition;
        //transform.position = new Vector2(mousePosition.x, mousePosition.y);
        //transform.LookAt(mousePosition);
        //var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);//угол между вектором от объекта к мыше и осью х
        //transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);//немного магии на последок
        //_transformPosition = transform.position;
    }    
}
