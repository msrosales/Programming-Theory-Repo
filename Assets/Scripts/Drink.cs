using UnityEngine;

//INHERITANCE
public abstract class Drink: MenuItem
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
		float priceOfWater = 1.00f;
		float priceOfIce = 1.00f;
		float priceOfSugar = 1.00f;

		return priceOfWater + priceOfIce + priceOfSugar;
	}
    
}
