using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevureSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrLevure;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrLevure = (int)value;
    }
}
