using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers_LerpDemo : MonoBehaviour
{
    public GameObject objectStart;
    public GameObject objectEnd;

    [Range(-1, 2)] public float percent = 0;

    public float animationLength = 2;
    public AnimationCurve animationCurve;
    private float animationPlayheadTime = 0;
    private bool isAnimPlaying = false;

    // Update is called once per frame
    void Update()
    {
        if (isAnimPlaying)
        {
            //move playhead forward:
            animationPlayheadTime += Time.deltaTime;
            //calc new value for percent:
            percent = animationPlayheadTime / animationLength;
            //clamp in 0 to 1 range:
            percent = Mathf.Clamp(percent, 0, 1);

            percent = animationCurve.Evaluate(percent);
            //percent = percent * percent * (3 - 2 * percent); //easeInOut (speeds up, slows down)

            //move object to lerped position:
            DoTheLerp();
            //stop playing:
            if (percent >= 1) isAnimPlaying = false;
        }
    }

    private void OnValidate()
    {
        DoTheLerp();
    }

    private void DoTheLerp()
    {
        transform.position = Powers_AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent, true);
    }

    public void PlayTweenAnim()
    {
        isAnimPlaying = true;
        animationPlayheadTime = 0;
    }
}
