using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionMixture : MonoBehaviour
{
    // Start is called before the first frame update
    public GestionBol bol;
   
    public bool verif =false;
    [SerializeField] private Renderer[] liquidRenderers=new Renderer[0];

    private float targetLiquidValue=1f;
    public float currentLiquidValue=0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bol.nbrElement>=5 && !verif){
            currentLiquidValue =Mathf.Lerp(currentLiquidValue,targetLiquidValue,300f*Time.deltaTime);
            foreach(Renderer renderer in liquidRenderers){
                renderer.material.SetFloat("_fluid",currentLiquidValue);
                verif=true;
            }
        }
        
    }
}
