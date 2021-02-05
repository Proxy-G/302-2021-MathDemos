using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_LerpBetweenTwoPoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float percent;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Powers_AnimMath.Lerp(pointA.position, pointB.position, percent, false);
        transform.position = Powers_AnimMath.Lerp(pointA.position, pointB.position, percent, false);
    }
}
