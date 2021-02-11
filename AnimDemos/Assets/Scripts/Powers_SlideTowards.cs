using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_SlideTowards : MonoBehaviour {
    public Transform target;
    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update() {
        //slides the position towards the target:
        transform.position = Powers_AnimMath.Slide(transform.position, target.position, 0.01f);

        //ease cam rotation to look at target:

        //get vector to target:
        Vector3 vectorToTarget = target.position - cam.transform.position ;

        //create desired rotation:
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);

        //set cam to ease towards target rotation:
        if (cam != null) cam.transform.rotation = Powers_AnimMath.Slide(cam.transform.rotation, targetRotation, 0.05f);
    }
}
