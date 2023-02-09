using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpwanSucre : MonoBehaviour
{

    [SerializeField] private SucreSliderScripte nombreDeSucreAFaireApparaite;
    [SerializeField] private Button btn;
    [SerializeField] GameObject Sucre;
    [SerializeField] GameObject ZonneDeSpwan;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonSelected);
    }
    
    // Update is called once per frame
    
    public void ButtonSelected(){
        for(int i=0;i<nombreDeSucreAFaireApparaite.nbrSucre;i++){
        Instantiate(Sucre,ZonneDeSpwan.transform.position,Quaternion.identity);
        }
    }
    // Update is called once per frame

    
}
