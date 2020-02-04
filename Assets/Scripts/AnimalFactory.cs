using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFactory : AbstractFactory
{
	public override IAnimal GetAnimal(AnimalType animalType)
	{
		switch (animalType)
		{
			case AnimalType.Cat:
				IAnimal cat = new Cat();
				return cat;
			case AnimalType.Bird:
				IAnimal Bird = new Bird();
				return Bird;
		}
		return null;
	}
	public override IHuman GetHuman(HumanType humanType)
	{
		return null;
	}
}