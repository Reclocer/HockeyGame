using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private Vector2Int _fieldSize = new Vector2Int(10, 10);
    [SerializeField] private List<GameObject> _cells;

    public void GenerateField()
    {
        for(int i = 0; i < _fieldSize.x; i++)
        {
            for(int j = 0; j < _fieldSize.y; j++)
            {
                Vector3 pos = new Vector3(i, j, 0);
                pos -= new Vector3(_fieldSize.x / 2, _fieldSize.y / 2, 0);
                CreateCell(pos);
            }
        }
    }

    private void CreateCell(Vector3 position)
    {
        var cell = Instantiate(_cellPrefab, transform);
        cell.transform.position = position;
        cell.gameObject.name = $"cell:{position}";
        _cells.Add(cell);
    }

    public void ClearField()
    {
        _cells.ForEach(c => DestroyImmediate(c.gameObject));
        _cells.Clear();
    }
}
