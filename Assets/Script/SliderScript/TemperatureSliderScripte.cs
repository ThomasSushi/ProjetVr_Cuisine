using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrTemperature;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrTemperature = (int)value;
    }
}
