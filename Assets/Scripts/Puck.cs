using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Puck : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    public Rigidbody2D Rb => _rb;

    [ContextMenu("Show Rb Info")] //даем возможность вызывать метод из инспектора
    public void ShowRbInfo()
    {
        Debug.Log($"Rb velocity of Puck: {_rb.velocity}");
    }

    [ContextMenu("Self destroy XXX")]
    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
