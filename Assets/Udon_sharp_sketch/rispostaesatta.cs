
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class rispostaesatta : UdonSharpBehaviour
{
    public GameObject reveal;
        public void RispostaEsatta()
        {
        Transform parent = transform.parent;
        parent.gameObject.SetActive(false);        
        reveal.SetActive(true);
        Debug.Log("Risposta esatta");
        }
    
}
