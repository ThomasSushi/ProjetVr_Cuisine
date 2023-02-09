using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanFarine : MonoBehaviour
{

    [SerializeField] private FarineSliderScripte nombreDeFarineAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject Farine;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeFarineAFaireApparaite.nbrFarine;i++){
        Instantiate(Farine,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
