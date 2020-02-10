using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLAYERPREFS : MonoBehaviour {


    public Text txt;
    public InputField caixaTxt;
    private float testeF;


	void Start () {

        txt.text = PlayerPrefs.GetFloat("pontos").ToString() + " pontos";
		
	}
	
	
	void Update () {
		
	}

    // CÓDIGO PRA SALVAR OS PONTOS:

    public void SalvarFloat()
    {
        testeF = float.Parse(caixaTxt.text);
        PlayerPrefs.SetFloat("pontos", testeF);
    }


}
