using UnityEngine;

//INHERITANCE
public class IceCream: Dessert
{

	//ENCAPSULATION
	protected new string _name = "Icecream";
	public new string Name{
		get => _name;
		set => _name = value;
	}

    
}
