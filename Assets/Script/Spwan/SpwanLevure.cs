using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanLevure : MonoBehaviour
{

    [SerializeField] private LevureSliderScripte nombreDeLevureAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject levure;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeLevureAFaireApparaite.nbrLevure;i++){
        Instantiate(levure,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
