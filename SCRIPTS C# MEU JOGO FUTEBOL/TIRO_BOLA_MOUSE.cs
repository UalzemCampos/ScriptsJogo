using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIRO_BOLA_MOUSE : MonoBehaviour {

    // VARIÁVEIS:

    private Rigidbody2D bola;
    private float force = 1000f;
    private ROTACAO_MOUSE rot;
    


    // COMO TODAS AS VARIÁVEIS SÃO PRIVADAS, TEMOS QUE INICIAR AS 2 QUE FALTA AQUI:

    void Start()
    {

        bola = GetComponent<Rigidbody2D>();
        rot = GetComponent<ROTACAO_MOUSE>();

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


        if (Input.GetKeyUp(KeyCode.Space))    //  APERTA A BARRA E SEGURA. TODA VEZ QUE SOLTAR VAI DAR O TIRO;
        {
            bola.AddForce(new Vector2(x, y));
        }
    }


}
