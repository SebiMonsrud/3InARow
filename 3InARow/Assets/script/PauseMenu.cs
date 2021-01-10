using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool IsPaused;

    GameManager GM;

    public GameObject _PauseMenu;

	// Use this for initialization
	void Start () {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (IsPaused)
        {
            GM.StopGame = true;
            _PauseMenu.SetActive(true);
        }
        else
        {
            GM.StopGame = false;
            _PauseMenu.SetActive(false);
        }
	}

    public void PauseButton()
    {
        if(IsPaused){
            IsPaused = false;
        }else{
        IsPaused = true;
        }
    }

    public void ReturnButton()
    {
        IsPaused = false;
    }
}
