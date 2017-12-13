using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class calculator : MonoBehaviour {

	public void ButtonPressed()
	{
		Debug.Log (EventSystem.current.currentSelectedGameObject.name);
	}

	public void ApplicationExit()
	{
		Application.Quit ();
	}
}
