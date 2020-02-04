using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanFactory : AbstractFactory
{
	public override IHuman GetHuman(HumanType humanType)
	{
		switch (humanType)
		{
			case HumanType.FratBoi:
				IHuman FratBoi = new FratBoi();
				return FratBoi;
			case HumanType.Farmer:
				IHuman farmer = new Farmer();
				return farmer;
			case HumanType.Shopowner:
				IHuman shopowner = new Shopowner();
				return shopowner;
		}
		return null;
	}
	public override IAnimal GetAnimal(AnimalType animalType)
	{
	return null;
	}
}