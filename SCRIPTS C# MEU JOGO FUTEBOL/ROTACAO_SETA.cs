using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ROTACAO_SETA : MonoBehaviour {


    // VARIÁVEIS:
    public Transform posStart;  // VARIÁVEL POSIÇÃO INICIAL SETA
    public Image setaImg;     // VARIÁVEL DA SETA
    public float zRotate;        // VARIÁVEL ANGULO DE ROTAÇÃO SETA


	void Start () {

        PosicionaSeta();        // METODO POS. SETA
        PosicionaBola();        // METODO POS. BOLA
		
	}
	
	
	void Update () {

        RotacaoSeta();
        InputDeRotacao();

		
	}

          //  METODO DA POSIÇÃO DA SETA:

    void PosicionaSeta()
    {
        setaImg.rectTransform.position = posStart.position;  // UI IMAGE = RECT TRANSFORM
    }


         // METODO POSIÇÃO DA BOLA:

    void PosicionaBola()
    {
        this.gameObject.transform.position = posStart.position;    // GAMEOBJECT = TRANSFORM
    }


            // MÉTODO ROTAÇÃO DA SETA:

    void RotacaoSeta()
    {
        setaImg.rectTransform.eulerAngles = new Vector3(0, 0, zRotate);  // EULERANGLES = ANGLO DE ROTAÇÃO
    }


                        // MÉTODO PARA A FORÇA DA ROTAÇÃO:


    void InputDeRotacao()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            zRotate = zRotate + 2.5f;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            zRotate = zRotate - 2.5f;
        }
    }


}
