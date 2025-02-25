using UnityEngine;
using TMPro;
using System;

public class ChooseHamburger : MonoBehaviour
{
	public TMP_Text nameText;
	public TMP_Text priceText;

	private Hamburger instance = new Hamburger();

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		nameText.text = "Name: " + instance.Name;
		priceText.text = "Price: " + instance.calculatePrice();
	}

	// Update is called once per frame
	void Update()
	{

	}
}
