using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoardButton : MonoBehaviour {

    bool IsActive;

    // null = 0 || X = 1 || O = 2
    public int active;

    PlayBoard PB;
    GameManager GM;
    Image image;
    public Image SpriteImage;
    public Color Standardcolor;
    public Color Xcolor;
    public Sprite Xsprite;
    public Color Ocolor;
    public Sprite Osprite;

    // Use this for initialization
    void Start () {
        image = GetComponent<Image>();
        GM = GameObject.FindGameObjectWithTag("GM").GetComponentInParent<GameManager>();
        PB = GameObject.FindGameObjectWithTag("GM").GetComponentInParent<PlayBoard>();
        Xsprite = PB.Xsprite;
        Osprite = PB.Osprite;
        Xcolor = PB.Xcolor;
        Ocolor = PB.Ocolor;
        Standardcolor = PB.StandardColor;
        SpriteImage.sprite = null;
        SpriteImage.gameObject.SetActive(false);
        active = 0;
        IsActive = false;
        image.color = Standardcolor;
    }
	
	// Update is called once per frame
	void Update () {

        if (active == 1) {
            image.color = Xcolor;
            SpriteImage.sprite = Xsprite;
            SpriteImage.gameObject.SetActive(true);
        }
        else if (active == 2) {
            image.color = Ocolor;
            SpriteImage.sprite = Osprite;
            SpriteImage.gameObject.SetActive(true);
        }
        else if(active == 0)
        {
            image.color = Standardcolor;
            SpriteImage.gameObject.SetActive(false);
            SpriteImage.sprite = null;
        }
    }

    public void Pushed()
    {
        if(IsActive == false && GM.StopGame == false)
        {
            IsActive = true;
            GM.NextPlayer = true;
            GM.activeButtons++;
            if (GM.ActivePlayer == 1)
            {
                active = 1;
            }else if (GM.ActivePlayer == 2)
            {
                active = 2;
            }
        }
        else
        {
            return;
        }
    }
    public void Reset()
    {
        IsActive = false;
        active = 0;
    }
}
