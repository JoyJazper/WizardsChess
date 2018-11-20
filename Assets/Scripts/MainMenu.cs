using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public GameObject MainMenuPanel;
	public GameObject InstructionPanel;
	public GameObject InstructionPanel1;
	// Use this for initialization
	void awake(){
		MainMenuPanel.gameObject.SetActive (true);
		InstructionPanel.gameObject.SetActive (false);
		InstructionPanel1.gameObject.SetActive (false);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onclickPlay(){
		MainMenuPanel.gameObject.SetActive (false);
		InstructionPanel.gameObject.SetActive (true);

	}

	public void onclickContinue(){
		InstructionPanel1.gameObject.SetActive (true);
		MainMenuPanel.gameObject.SetActive (false);
		InstructionPanel.gameObject.SetActive (false);

	}

	public void onclickcontinue1(){
		InstructionPanel1.gameObject.SetActive (false);
	}

	public void restart(){
		
	}
}
