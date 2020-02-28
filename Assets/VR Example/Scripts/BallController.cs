using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Transform m_StartPosition;
    public float m_BallOffsetFromStart = 1f;
    private Rigidbody m_Rigidbody;

    void Start()
    {
        // Get the Rigidbody component on the ball (the object that this script is supposed to be on)
        m_Rigidbody = GetComponent<Rigidbody>();
        // Set the Rigidbodies parameter isKinematic to true, so that the ball is not affected by physics before we have actually started the game
        m_Rigidbody.isKinematic = true;
        // Set the balls position to the start position Transform objects position
        transform.position = m_StartPosition.position;
    }

    public void OnBallInBucket()
    {
        // Whenever this method is called, it starts the coroutine
        StartCoroutine(WaitAndResetBall());
    }

    IEnumerator WaitAndResetBall()
    {
        // Before doing anything, make the script wait for some time
        yield return new WaitForSeconds(1f);

        // We check if the balls rigidbody component is kinematic, and if it is - set it to false, so that the ball is affected by physics
        // We need this since we are using this coroutine to also start the game, where before that, it is needed to be stationary
        if (m_Rigidbody.isKinematic == true)
        {
            m_Rigidbody.isKinematic = false;
        }
        // Here we reset the ball
        // Reset the rigidbodies velocity and angular velocity (basically all movement)
        m_Rigidbody.velocity = Vector3.zero;
        m_Rigidbody.angularVelocity = Vector3.zero;
        // Create a new position vector3 variable with some random offset on the X axis
        Vector3 pos = new Vector3(m_StartPosition.position.x + Random.Range(-m_BallOffsetFromStart, m_BallOffsetFromStart), m_StartPosition.position.y, m_StartPosition.position.z);
        // Set the balls position to the new position
        transform.position = pos;
    }
}
