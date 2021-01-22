using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_SlideTowards : MonoBehaviour {
    public Transform target;
    
    void Update() {
        transform.position = Powers_AnimMath.Slide(transform.position, target.position, 0.01f);
    }
}
