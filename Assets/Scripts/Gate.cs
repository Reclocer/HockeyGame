using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate : MonoBehaviour
{
    [SerializeField] private Collider2D _puck;

    //Score
    [SerializeField] private Text _score;
    private int _scoreI = 0;
    public int ScoreI => _scoreI;

    private string _scoreS;
    public string ScoreS => _scoreS;
    public event Action<Gate> OnGoal = (thisGate) => { };

    [SerializeField] private Transform _puckStartPosition;
    public Transform PuckStartPosition => _puckStartPosition;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == _puck)
        {
            _scoreI++;
            _scoreS = _scoreI.ToString();
            _score.text = _scoreS;
            OnGoal(this);
        }
    }
}
