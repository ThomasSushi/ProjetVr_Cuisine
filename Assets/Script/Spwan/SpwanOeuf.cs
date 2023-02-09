using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanOeuf : MonoBehaviour
{

    [SerializeField] private OeufSliderScripte nombreDeOeufAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject Oeuf;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeOeufAFaireApparaite.nbrOeuf;i++){
        Instantiate(Oeuf,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
