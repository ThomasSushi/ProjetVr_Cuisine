using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarineSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrFarine;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrFarine = (int)value;
    }
}
