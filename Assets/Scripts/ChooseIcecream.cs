using UnityEngine;
using TMPro;
using System;

public class IcecreamChoice : MonoBehaviour
{
	public TMP_Text nameText;
	public TMP_Text priceText;

	private IceCream instance = new IceCream();

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
