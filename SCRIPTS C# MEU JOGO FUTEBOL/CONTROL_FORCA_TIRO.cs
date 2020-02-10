using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONTROL_FORCA_TIRO : MonoBehaviour {

    // VARIÁVEIS:

    private Rigidbody2D bola;
    private float force = 1000f;
    private ROTACAO_CONTROL_FORCE rot;
    public Image seta2Img;



    // COMO TODAS AS VARIÁVEIS SÃO PRIVADAS, TEMOS QUE INICIAR AS 2 QUE FALTA AQUI:

    void Start()
    {

        bola = GetComponent<Rigidbody2D>();
        rot = GetComponent<ROTACAO_CONTROL_FORCE>();

    }

    // MÉTODO QUE VAI DAR UPDATE A TODO MOMENTO:
    void Update()
    {
        ControlaForca();
        AplicaForca();

    }

    // MÉTODO DA FORÇA DO TIRO DA BOLA:

    void AplicaForca()
    {
        // CÁLCULO DE SENO E COSCENO:

        float x = force * Mathf.Cos(rot.zRotate * Mathf.Deg2Rad);   // X = COSENO
        float y = force * Mathf.Sin(rot.zRotate * Mathf.Deg2Rad);   // Y = SENO

        if (rot.liberaTiro == true)

        {
            bola.AddForce(new Vector2(x, y));
            rot.liberaTiro = false;
        }
    }

                  // MÉTODO PARA CONTROLAR FORÇA DO TIRO

    void ControlaForca()
    {
        if(rot.liberaRot == true)
        {
            float moveX = Input.GetAxis("Mouse X"); // O MOVIMENTO DE X, PRA CIMA E PRA BAIXA CONTROLA QUANT DE FORÇA

            if (moveX < 0)
            {
                seta2Img.fillAmount = seta2Img.fillAmount + 1 * Time.deltaTime;
                force = seta2Img.fillAmount * 1000;
            }

            if (moveX > 0)
            {
                seta2Img.fillAmount = seta2Img.fillAmount - 1 * Time.deltaTime;
                force = seta2Img.fillAmount * 1000;
            }
        }
    }


}

