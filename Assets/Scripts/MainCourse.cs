using UnityEngine;

//INHERITANCE
public abstract class MainCourse: MenuItem
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
		float priceOfGameMeat = 4.05f;
		float priceOfPotatoes = 3.50f;
		float priceOfCarrots = 1.00f;

		return priceOfGameMeat + priceOfPotatoes + priceOfCarrots;
	}

}
