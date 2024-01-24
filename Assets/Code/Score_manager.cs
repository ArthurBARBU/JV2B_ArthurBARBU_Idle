using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_manager : MonoBehaviour
{

    public int _score=0;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RiseScore(int amount)
    {
        _score += amount;
        scoreText.text = _score.ToString("00000");


    }

    public void OnMouseDown()
    {
        RiseScore(1);
    }

}

