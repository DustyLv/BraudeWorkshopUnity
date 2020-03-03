using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    public BallController m_BallController;
    public PointScript m_PointScript;

    // This is a Unity built-in function, that gets automatically called when the trigger collider of the object has some other object enter it
    // the 'other' parameter is the object that enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // We check if the entering object has a specific tag, so that we know for sure that the correct object has entered
        if (other.tag == "Ball")
        {
            // Call the ball reset function on the BallController script
            m_BallController.OnBallInBucket();
            // Call the function to add points for catching the ball
            m_PointScript.AddPoints();
        }
    }
}
