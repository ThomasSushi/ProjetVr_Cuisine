using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YaourtSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrYaourt;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrYaourt = (int)value;
    }
}
