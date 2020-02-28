using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketMoveKeyboard : MonoBehaviour
{
    public float m_MoveSpeed = 2f;

    void Update()
    {
        // We get the users keyboard input for the Left/Right arrowkeys and A/D keys
        // Unity has made these keys available as an axis:
            // If none of these keys are pressed the Input.GetAxis() returns 0
            // If A or Left Arrowkey is pressed, it returns -1
            // If D or Right Arrowkey is pressed, it return 1
        float inputHorizontal = Input.GetAxis("Horizontal");

        // We can then use the Horizontal axis input to move the object left or right without specifically checking if the key is pressed
        // transform has direction vector variables exposed - here we need to move on the X axis and in Unity it is indicated as transform.right (or Vector3.right) which basically is Vector3(1,0,0)
        // To make it move left or right, we multiply the direction by our input to specify left or right, and multiply that again by some set speed value to make it move slower or faster.
        // We also multiply by Time.deltaTime, which just normalizes the speed and makes it so that on every device/computer the movement is the same speed
            // Without it, on a slower/less powerful computer the object would move slower, but on a faster one - it would move faster. That's because the faster the computer, the faster it can compute this.
        transform.Translate(transform.right * inputHorizontal * m_MoveSpeed * Time.deltaTime);
    }
}
