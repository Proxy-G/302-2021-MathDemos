using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_OrbitCameraControl : MonoBehaviour
{
    /// <summary>
    /// This scales the horizontal mouse input
    /// </summary>
    public float mouseSensitivityX = 1;
    /// <summary>
    /// This scales the vertical mouse input
    /// </summary>
    public float mouseSensitivityY = 1;
    /// <summary>
    /// This scales the mouse scroll input
    /// </summary>
    public float mouseScrollMultiplier = 1;

    /// <summary>
    /// The tilt of the camera in degrees
    /// </summary>
    private float pitch;
    /// <summary>
    /// The tilt of the camera in degrees that we want
    /// </summary>
    private float targetPitch;
    /// <summary>
    /// The yaw angle of the camera rig in degrees
    /// </summary>
    private float yaw;
    /// <summary>
    /// The tilt of the camera in degrees that we want
    /// </summary>
    private float targetYaw;

    /// <summary>
    /// How far away the camera should be from its target, in meters
    /// </summary>
    public float dollyDis = 10;
    /// <summary>
    /// How far away the camera should be from its target, in meters, that we want
    /// </summary>
    private float targetDollyDis = 10;

    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            //changing the pitch:
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            targetYaw += mouseX * mouseSensitivityX;
            targetPitch += mouseY * mouseSensitivityY;
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");
        targetDollyDis += scroll * mouseScrollMultiplier;
        targetDollyDis = Mathf.Clamp(dollyDis, 2.5f, 15);

        dollyDis = Powers_AnimMath.Slide(dollyDis, targetDollyDis, 0.05f);

        cam.transform.localPosition = new Vector3(0, 0, -dollyDis); //EASE

        //changing the rotation to match the pitch variable:
        targetPitch = Mathf.Clamp(targetPitch, -89, 89);

        pitch = Powers_AnimMath.Slide(pitch, targetPitch, 0.05f); //EASE
        yaw = Powers_AnimMath.Slide(yaw, targetYaw, 0.05f); //EASE


        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
    }
}
