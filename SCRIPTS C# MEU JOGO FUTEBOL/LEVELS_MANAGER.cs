using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LEVELS_MANAGER : MonoBehaviour {

	// AQUI DERIALIZAMOS TUDO:

        [System.Serializable]

        // CLASSE DOS NIVEIS:

        public class Level

    {               // VARIÁVEIS DA CLASSE LEVEL:


        public string levelText;
        public bool habilitado;
        public int desbloqueado;
    }

    // VARIÁVEIS DA CLASSE LEVELS_MANAGER:

    public GameObject botao;
    public Transform localBtn;
    public List<Level> levelList;


                 // MÉTODO da LISTA:

        void ListaAdd()
    {
        foreach (Level level in levelList)
        {
            GameObject btnNovo = Instantiate(botao) as GameObject;

            BOTAO_MANAGERS btnNew = btnNovo.GetComponent<BOTAO_MANAGERS>();
            btnNew.levelTxtBTN.text = level.levelText;
            btnNew.desbloqueadoBTN = level.desbloqueado;
            btnNew.GetComponent<Button>().interactable = level.habilitado;


            btnNovo.transform.SetParent(localBtn, false);
        }
    }

	void Start () {

        // INICIAMOS NOSSA LISTA:
        ListaAdd();
		
	}
	
	
	void Update () {
		
	}
}
