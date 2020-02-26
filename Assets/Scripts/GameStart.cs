using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool m_GameStarted = false;
    public BallController m_GameBall;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (m_GameStarted == false)
        {
            m_GameBall.OnBallInBucket();
            m_GameStarted = true;
        }
    }
}
