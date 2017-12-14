using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class calculator : MonoBehaviour {

	[SerializeField]
	Text outputTextField;
	private string s_valueB;
	private int valueA;
	private int valueB;
	private bool isOperation = false;
	private bool isOperationFirstTime = false;

	public void ButtonPressed()
	{
		if (isOperation) {

			if (isOperationFirstTime) 
			{
				outputTextField.text += "\n";
				isOperationFirstTime = false;
			}
			s_valueB += EventSystem.current.currentSelectedGameObject.name;

		} 

		outputTextField.text += EventSystem.current.currentSelectedGameObject.name;

	}

	public void ApplicationExit()
	{
		Application.Quit ();
	}

	public void ClearOut()
	{
		outputTextField.text = "";
	}

	public void Addition()
	{
		
		int.TryParse (outputTextField.text, out valueA);
		outputTextField.text += " + ";
		isOperation = true;
		isOperationFirstTime = true;
	}

	public void EqualSign()
	{
		int.TryParse (s_valueB, out valueB);
		valueA = valueA + valueB;
		outputTextField.text = valueA.ToString();
		isOperation = false;
	}
}
