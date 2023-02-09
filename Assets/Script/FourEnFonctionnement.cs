using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourEnFonctionnement : MonoBehaviour
{
    [SerializeField] private Button btn;
    [SerializeField] private TempsSliderScripte Temps ;
    [SerializeField] private TemperatureSliderScripte Temperature;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    public void ButtonSelected(){

        if((175<=Temperature.nbrTemperature)&&(Temperature.nbrTemperature<=185)&&(30<=Temps.nbrTemps)&&(Temps.nbrTemps<=35)){
            Debug.Log("vous avez bien fait la cuisson");
        }
        else{
            Debug.Log("vous vous etes trompé dans la cuisson");
        }

    }

}
