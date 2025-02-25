using UnityEngine;

//INHERITANCE
public class Coffee: Drink
{
	//ENCAPSULATION
	protected new string _name = "Coffee";
	public new string Name{
		get => _name;
		set => _name = value;
	}
}
