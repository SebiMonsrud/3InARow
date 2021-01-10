using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {


    Menus _Menus;

	// Use this for initialization
	void Start () {
        _Menus = GetComponentInParent<Menus>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackButton()
    {
        _Menus.SettingsBackButon();
    }

}
