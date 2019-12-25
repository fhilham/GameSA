using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_menu : MonoBehaviour {

	public void GoToMainMenu(){
		Application.LoadLevel("main_menu");
	}

	public void GoToARCamera(){
		Application.LoadLevel("ARCamera");
	}

    public void GoToPreGame()
    {
        Application.LoadLevel("preGame");
    }

    public void GoToGamePlay()
    {
        Application.LoadLevel("GamePlay");
    }
    public void GoToInfo()
    {
        Application.LoadLevel("Info");
    }

     public void GoToAboutUs() {
         Application.LoadLevel("About");
    }

	public void ExitApplication(){
		Application.Quit ();
	}
}
