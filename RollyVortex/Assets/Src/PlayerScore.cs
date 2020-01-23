using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public PlayerCollisionHandler player = null;
    private Text _text = null;
    private int _currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _currentScore = player.SectionsTraversed;
        _text.text = _currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int score = player.SectionsTraversed;
        if (score != _currentScore)
        {
            _currentScore = score;
            _text.text = _currentScore.ToString();
        }
    }
}
