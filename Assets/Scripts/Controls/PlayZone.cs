using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayZone : MonoBehaviour
{
    [SerializeField] private Color _gizmosColor = Color.red;
    [SerializeField] private Vector2 _center;
    [SerializeField] private Vector2 _size;
    private Rect _rect;
    public bool IsOutOfBounds(Vector2 pos)
    {
        Vector2 pivotOfRect = _center - (_size / 2);
        _rect = new Rect(pivotOfRect, _size);
        return !_rect.Contains(pos);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _gizmosColor;
        Gizmos.DrawCube(_center, _size);
    }

}
