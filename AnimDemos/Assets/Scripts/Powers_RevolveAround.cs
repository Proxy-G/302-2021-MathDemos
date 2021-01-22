using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_RevolveAround : MonoBehaviour
{
    public Transform target;
    public float radius = 2;
    private float age = 0;

    void Update()
    {
        age += Time.deltaTime;

        Vector3 offset = Powers_AnimMath.SpotOnCircleXZ(radius, age);

        transform.position = target.position + offset;
    }
}
