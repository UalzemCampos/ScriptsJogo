using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIDA_BOMBA : MonoBehaviour {


    private GameObject bombaRep;


	void Start () {

        bombaRep = GameObject.Find("barril");

		
	}
	
	
	void Update () {

        StartCoroutine (Vida());

		
	}

    IEnumerator Vida()
    {
        yield return new WaitForSeconds(0.4f);

        Destroy(bombaRep.gameObject);
        Destroy(this.gameObject);
    }

}
