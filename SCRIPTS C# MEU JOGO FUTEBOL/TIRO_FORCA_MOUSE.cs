using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIRO_FORCA_MOUSE : MonoBehaviour
{

    // VARIÁVEIS:

    private Rigidbody2D bola;
    private float force = 1000f;
    private FORCA_MOUSE rot;



    // COMO TODAS AS VARIÁVEIS SÃO PRIVADAS, TEMOS QUE INICIAR AS 2 QUE FALTA AQUI:

    void Start()
    {

        bola = GetComponent<Rigidbody2D>();
        rot = GetComponent<FORCA_MOUSE>();

    }

    // MÉTODO QUE VAI DAR UPDATE A TODO MOMENTO:
    void Update()
    {

        AplicaForca();

    }

    // MÉTODO DA FORÇA DO TIRO DA BOLA:

    void AplicaForca()
    {
        // CÁLCULO DE SENO E COSCENO:

        float x = force * Mathf.Cos(rot.zRotate * Mathf.Deg2Rad);   // X = COSENO
        float y = force * Mathf.Sin(rot.zRotate * Mathf.Deg2Rad);   // Y = SENO

        if(rot.liberaTiro == true)

        {
            bola.AddForce(new Vector2(x, y));
            rot.liberaTiro = false;
        }
    }


}

