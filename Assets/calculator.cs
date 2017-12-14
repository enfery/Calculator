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
	// 1 + 2 - 3 / 4 *
	private int operationNum = 0;

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

	private void OperationStart()
	{
		if (isOperation) 
		{
			EqualSign ();
		}
		int.TryParse (outputTextField.text, out valueA);
		isOperation = true;
		isOperationFirstTime = true;
	}

	public void Addition()
	{
		OperationStart ();
		outputTextField.text += " + ";
		operationNum = 1;
	}

	public void Subtraction()
	{
		OperationStart ();
		outputTextField.text += " - ";
		operationNum = 2;

	}

	public void EqualSign()
	{
		int.TryParse (s_valueB, out valueB);
		Debug.Log ("valueA = " + valueA + " valueB = " + valueB);
		switch (operationNum) 
		{
		case 1:
			valueA = valueA + valueB;
			break;
		case 2:
			valueA = valueA - valueB;
			break;
		default:
			Debug.Log ("Not yet soz");
			break;
		}
		outputTextField.text = valueA.ToString();
		isOperation = false;
		s_valueB = "";

	}
		
}
