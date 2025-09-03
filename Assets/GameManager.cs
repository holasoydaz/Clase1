using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
	public Animator animator;
	public int cantidad;
	public TextMeshProUGUI text;
	public void Add()
	{
		cantidad++;
		text.text = cantidad.ToString();
		Buttom_Press();
	}
	public void Buttom_Press()
	{ 
		animator.SetTrigger("Button");
	}
}
