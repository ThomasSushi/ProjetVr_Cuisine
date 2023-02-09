using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PommeSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrPomme;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrPomme = (int)value;
    }
}
