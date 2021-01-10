using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public WinnerPanel WP;
    PlayBoard PB;
    Timer timer;
    public bool IsPaused;
    
    public int activeButtons;

    public bool NextPlayer;
    //X = 1 || O = 2
    public int ActivePlayer;

    public bool XIsWinner;
    public bool OIsWinner;
    public bool StopGame;

    // Use this for initialization
    void Start () {
        ActivePlayer = 1;
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        PB = GetComponent<PlayBoard>();
	}
	
	// Update is called once per frame
	void Update () {

        if (XIsWinner && StopGame == false)
        {
            Debug.Log("X WON!!");
            StopGame = true;
            WP.gameObject.SetActive(true);
            return;
        } else if (OIsWinner && StopGame == false)
        {
            StopGame = true;
            Debug.Log("O WON!!");
            WP.gameObject.SetActive(true);
            return;
        }

        if (NextPlayer)
        {
            NextPlayer = false;
            if (ActivePlayer == 1)
            {
                ActivePlayer = 2;
            }else if (ActivePlayer == 2)
            {
                ActivePlayer = 1;
            }
        }

        if(activeButtons == 9 && StopGame == false)
        {
            Invoke("Restart", 1f);
        }

        if (IsPaused || StopGame)
        {
            return;
        }
        else
        {
            timer.Time += 1 * Time.deltaTime;
        }
		
	}

    public void RestartButton()
    {
        Restart();
        WP.gameObject.SetActive(false);
        StopGame = false;
        timer.Time = 0;
        timer.Secounds = 0;
        timer.Minutes = 0;
        XIsWinner = false;
        OIsWinner = false;
    }

    public void HomeButton(){
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        PB.Restart();
        ActivePlayer = 1;
        activeButtons = 0;
    }
}
