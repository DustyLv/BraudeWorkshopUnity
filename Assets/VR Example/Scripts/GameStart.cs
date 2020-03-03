using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool m_GameStarted = false;
    public BallController m_GameBall;

    // This function will be called from a UI button
    public void StartGame()
    {
        // We check if the game hasn't already been started and start the game by calling the ball reset function
        if (m_GameStarted == false)
        {
            m_GameBall.OnBallInBucket();
            m_GameStarted = true;
        }
    }

    // This is basically the same as StartGame, but it's meant to reset the ball position in case the ball has not been caught
    public void ResetGame()
    {
        if (m_GameStarted == true)
        {
            m_GameBall.OnBallInBucket();
        }
    }

}
