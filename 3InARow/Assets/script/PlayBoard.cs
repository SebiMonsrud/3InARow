using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBoard : MonoBehaviour {
    [Header("row1:")]
    public GameBoardButton B1x1;
    public GameBoardButton B1x2;
    public GameBoardButton B1x3;
    [Header("row2:")]
    public GameBoardButton B2x1;
    public GameBoardButton B2x2;
    public GameBoardButton B2x3;
    [Header("row3:")]
    public GameBoardButton B3x1;
    public GameBoardButton B3x2;
    public GameBoardButton B3x3;
    [Header("SpriteSettings:")]
    public Sprite Xsprite;
    public Sprite Osprite;
    public Color Ocolor;
    public Color Xcolor;
    public Color StandardColor;

    GameManager GM;

    // Use this for initialization
    void Start () {
        GM = GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckRows();
        CheckColons();
        CheckCross();
    }

    void CheckColons()
    {
        if (B1x1.active == 1 && B2x1.active == 1 && B3x1.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x2.active == 1 && B2x2.active == 1 && B3x2.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x3.active == 1 && B2x3.active == 1 && B3x3.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x1.active == 2 && B2x1.active == 2 && B3x1.active == 2)
        {
            GM.OIsWinner = true;
        }
        if (B1x2.active == 2 && B2x2.active == 2 && B3x2.active == 2)
        {
            GM.OIsWinner = true;
        }
        if (B1x3.active == 2 && B2x3.active == 2 && B3x3.active == 2)
        {
            GM.OIsWinner = true;
        }
    }

    void CheckRows()
    {
        if (B1x1.active == 1 && B1x2.active == 1 && B1x3.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B2x1.active == 1 && B2x2.active == 1 && B2x3.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B3x1.active == 1 && B3x2.active == 1 && B3x3.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x1.active == 2 && B1x2.active == 2 && B1x3.active == 2)
        {
            GM.OIsWinner = true;
        }
        if (B2x1.active == 2 && B2x2.active == 2 && B2x3.active == 2)
        {
            GM.OIsWinner = true;
        }
        if (B3x1.active == 2 && B3x2.active == 2 && B3x3.active == 2)
        {
            GM.OIsWinner = true;
        }
    }

    void CheckCross()
    {
        if (B1x1.active == 1 && B2x2.active == 1 && B3x3.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x3.active == 1 && B2x2.active == 1 && B3x1.active == 1)
        {
            GM.XIsWinner = true;
        }
        if (B1x1.active == 2 && B2x2.active == 2 && B3x3.active == 2)
        {
            GM.OIsWinner = true;
        }
        if (B1x3.active == 2 && B2x2.active == 2 && B3x1.active == 2)
        {
            GM.OIsWinner = true;
        }
    }

    public void Restart()
    {
        B1x1.Reset();
        B1x2.Reset();
        B1x3.Reset();
        B2x1.Reset();
        B2x2.Reset();
        B2x3.Reset();
        B3x1.Reset();
        B3x2.Reset();
        B3x3.Reset();
    }
}
