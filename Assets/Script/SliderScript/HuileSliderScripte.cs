using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HuileSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrHuile;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrHuile = (int)value;
    }
}
