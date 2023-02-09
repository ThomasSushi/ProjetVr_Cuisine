using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SucreSliderScripte : MonoBehaviour
{
    public Text valueText;
    public int nbrSucre;
    public void OnSliderChanged(float value){
        valueText.text = value.ToString();
        nbrSucre=(int)value;
    }
}
