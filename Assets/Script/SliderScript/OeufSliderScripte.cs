using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OeufSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrOeuf;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrOeuf = (int)value;
    }
}
