using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_LerpDemo : MonoBehaviour
{
    public GameObject objectStart;
    public GameObject objectEnd;
    
    public float percent = 0;

    // Update is called once per frame
    void Update()
    {
        DoTheLerp();
    }

    private void OnValidate()
    {
        DoTheLerp();
    }

    private void DoTheLerp()
    {
        transform.position = Powers_AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent, true);
    }
}
