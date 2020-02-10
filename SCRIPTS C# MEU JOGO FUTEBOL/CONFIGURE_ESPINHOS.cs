using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONFIGURE_ESPINHOS : MonoBehaviour {

    // VARIÁVEIS:

    private SliderJoint2D espinho;
    private JointMotor2D aux;

	void Start () {   // COMO AS VARIÁVEIS SÃO PRIVATE TEMOS QUE INICIÁ-LAS:

        espinho = GetComponent<SliderJoint2D>();
        aux = espinho.motor;
		
	}
	
	
	void Update () {


        if (espinho.limitState == JointLimitState2D.UpperLimit) // UPPER - NEGATIVO
        {
            aux.motorSpeed = Random.Range(-1, -5);    // QUER DIZER QUE IRÁ VARIAR(USADO PRA MUITAS COISAS)
            espinho.motor = aux;
        }


        if (espinho.limitState == JointLimitState2D.LowerLimit)  // LOWER - POSITIVO
        {
            aux.motorSpeed = Random.Range(1, 5);    // QUER DIZER QUE IRÁ VARIAR(USADO PRA MUITAS COISAS)
            espinho.motor = aux;
        }

    }
}
