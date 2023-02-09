using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempsSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrTemps;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrTemps = (int)value;
    }
}
