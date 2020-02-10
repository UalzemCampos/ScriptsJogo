using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ROTACAO_CONTROL_FORCE : MonoBehaviour {

    // VARIÁVEIS:
    public Transform posStart;  // VARIÁVEL POSIÇÃO INICIAL SETA
    public Image setaImg;     // VARIÁVEL DA SETA
    public float zRotate;        // VARIÁVEL ANGULO DE ROTAÇÃO SETA
    public bool liberaRot = false;         // VARIÁVEL LIBERA ROTAÇÃO
    public bool liberaTiro = false;          // PRA LIBERAR O TIRO APÓS MIRAR


    void Start()
    {

        PosicionaSeta();        // METODO POS. SETA
        PosicionaBola();        // METODO POS. BOLA

    }


    void Update()
    {

        RotacaoSeta();
        InputDeRotacao();
        LimitaRotacao();


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
        if (liberaRot == true)
        {
            //float moveX = Input.GetAxis("Mouse X"); - NÃO USAREMOS AQUI
            float moveY = Input.GetAxis("Mouse Y");




            if (zRotate < 90)
            {
                if (moveY > 0)
                {
                    zRotate = zRotate + 2.5f;
                }
            }
            if (zRotate > 0)
            {
                if (moveY < 0)
                {
                    zRotate = zRotate - 2.5f;
                }
            }
        }
    }

    // LIMITA A ROTAÇÃO À 90 GRAUS:

    void LimitaRotacao()
    {
        if (zRotate >= 90)
        {
            zRotate = 90;
        }

        if (zRotate <= 0)
        {
            zRotate = 0;
        }
    }

    //  MÉTODO PARA MOVIMENTAR QUANDO MOUSE ESTIVER NELA:

    void OnMouseDown()
    {
        liberaRot = true;
    }

    void OnMouseUp()
    {
        liberaRot = false;
        liberaTiro = true;
    }

}



