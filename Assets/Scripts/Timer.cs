using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
	float timeLeft24 = 50.0f;
	float timeleft2 = 10.0f;
	public bool a;
	///Text text;

	void Update()
	{
		hourcheck ();
		daycheck ();
	}

	public void hourcheck(){
		while (a = true) {
			timeleft2 -= Time.deltaTime;
			Debug.Log (timeleft2);
			if(timeleft2 < 0)
			{
				Debug.Log("New Challenge!!");
				a = false;
				//Event call
			}
		}
	}

	public void daycheck(){
		while (a = false) {
			timeLeft24 -= Time.deltaTime;
			Debug.Log (timeLeft24);
			if(timeLeft24 < 0)
			{
				Debug.Log("Challenge time out!!");
				//Event call
			}
		}
	}
	// event function which should put the value of a as true.....
}