using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourEnFonctionnement : MonoBehaviour
{
    [SerializeField] private Button btn;
    [SerializeField] private TempsSliderScripte Temps ;
    [SerializeField] private TemperatureSliderScripte Temperature;

    [SerializeField] private GameObject gateauBon;
    [SerializeField] private GameObject gateauPasCuis;
    [SerializeField] private GameObject gateauTropCuis;
    [SerializeField] private GameObject Spawn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    public void ButtonSelected(){

        if((175<=Temperature.nbrTemperature)&&(Temperature.nbrTemperature<=185)&&(30<=Temps.nbrTemps)&&(Temps.nbrTemps<=35)){
            Instantiate(gateauBon,Spawn.transform.position,Quaternion.identity);
        }
        if((186<=Temperature.nbrTemperature)&&(36<=Temps.nbrTemps)){
            Instantiate(gateauTropCuis,Spawn.transform.position,Quaternion.identity);
        }
        if((175>=Temperature.nbrTemperature)&&(29>=Temps.nbrTemps)){
            Instantiate(gateauPasCuis,Spawn.transform.position,Quaternion.identity);
        } 
    }

}
