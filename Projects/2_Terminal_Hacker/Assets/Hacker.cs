using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();
	}

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("YOU HAVE AWOKEN THE ALMIGHTY SHENRON!\nSPEAK YOUR WISH NOW!");
        Terminal.WriteLine("----------------------------");
        Terminal.WriteLine("1. Give me a new partner!");
        Terminal.WriteLine("2. I want a strong opponent!");
        Terminal.WriteLine("3. I need some new moves!");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
