using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class calculator : MonoBehaviour {

	[SerializeField]
	Text outputTextField;
	private string buttonValue;

	public void ButtonPressed()
	{
		Debug.Log (EventSystem.current.currentSelectedGameObject.name);
		buttonValue = EventSystem.current.currentSelectedGameObject.name;
		outputTextField.text += buttonValue;
	}

	public void ApplicationExit()
	{
		Application.Quit ();
	}

	public void ClearOut()
	{
		outputTextField.text = "";
	}
}
