using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanHuile : MonoBehaviour
{

    [SerializeField] private HuileSliderScripte nombreDeHuileAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject huile;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeHuileAFaireApparaite.nbrHuile;i++){
        Instantiate(huile,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
