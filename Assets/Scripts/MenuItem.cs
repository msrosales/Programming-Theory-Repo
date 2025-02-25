using UnityEngine;

public abstract class MenuItem
{
	//ENCAPSULATION
	protected string _name;
	public string Name{get; protected set;}

	//ENCAPSULATION
	protected string _category;
	public string Category{get; protected set;}

	//POLYMORPHISM
	public abstract float calculatePrice();    
}
