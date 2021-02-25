using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustBottle : MonoBehaviour
{

    private Slider RotateSlider;
    private Slider ScaleSlider;
    public float rotationMin;
    public float rotationMax;
    public float scaleMin;
    public float scaleMax;
    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        ScaleSlider.minValue = scaleMin;
        ScaleSlider.maxValue = scaleMax;
        ScaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        RotateSlider.minValue = rotationMin;
        RotateSlider.maxValue = rotationMax;
        RotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
    }

    public void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    public void RotateSliderUpdate(float value) 
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x + 30, value, transform.rotation.z);
    }
}
