using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerPanel : MonoBehaviour {

    public Image image;
    public Color XColor;
    public Color OColor;
    GameManager GM;

    public Sprite Xsprite;
    public Sprite Osprite;


    // Use this for initialization
    void Start () {
        image = GameObject.Find("WinnerImage").GetComponent<Image>();
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GM.XIsWinner)
        {
            image.sprite = Xsprite;
            image.color = XColor;
        }else if (GM.OIsWinner)
        {
            image.sprite = Osprite;
            image.color = OColor;
        }
        else
        {
            image.sprite = null;
        }
    }
}
