using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanYaourt : MonoBehaviour
{

    [SerializeField] private YaourtSliderScripte nombreDeYaourtAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject Yaourt;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeYaourtAFaireApparaite.nbrYaourt;i++){
        Instantiate(Yaourt,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
