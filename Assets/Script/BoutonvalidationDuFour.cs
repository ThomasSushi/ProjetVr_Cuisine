using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoutonvalidationDuFour : MonoBehaviour
{
    private Button btn;
    [SerializeField] private Text temperature;
    int valTemperature;
    [SerializeField] private Text temps;
    int valTemps;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(ButtonSelected);
    }
    void ButtonSelected(){

        // if((175<temperature.ToInt()<185)&&(28<valTemps.ToInt()<32)){
        //     Debug.Log("vous avez bien fait la cuisson");
        // }
        // else{
        //     Debug.Log("vous vous etes trompé dans la cuisson");
        // }

    }
    // Update is called once per frame
    
}
