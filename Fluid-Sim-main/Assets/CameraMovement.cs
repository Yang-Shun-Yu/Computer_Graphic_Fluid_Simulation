using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    // Update is called once per frame
    public float speed = 5.0f;
    public float sensitivity = 1.0f;
    private bool isCameraMovable = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            // Toggle the camera movement
            isCameraMovable = !isCameraMovable;
        }

        if (isCameraMovable)
        {
            // Move the camera forward, backward, left, and right
            transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            // Rotate the camera based on the mouse movement
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);
        }
    }
}
