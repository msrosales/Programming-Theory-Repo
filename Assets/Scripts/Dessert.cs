using UnityEngine;

//INHERITANCE
public abstract class Dessert: MenuItem
{

	//ENCAPSULATION
	protected new string _category;
	public new string Category{
		get => _category;
		set => _category = value;
	}

	//POLYMORPHISM
	//ABSTRACTION
	public override float calculatePrice(){
		float priceOfSugar = 2.00f;
		float priceOfFruits = 2.00f;
		float priceOfGelatine = 1.33f;
		return priceOfSugar + priceOfFruits + priceOfGelatine;
	}
    
}
