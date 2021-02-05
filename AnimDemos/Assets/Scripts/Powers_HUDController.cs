using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Powers_HUDController : MonoBehaviour
{
    public TMP_Text textTimeScale;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TimeSliderUpdated(float amt)
    {
        Time.timeScale = amt;
        textTimeScale.text = System.Math.Round(Time.timeScale, 2).ToString();
    }

    public void SliderLerpUpdated(float amt)
    {

    }
}
