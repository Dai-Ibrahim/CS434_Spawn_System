using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
	public abstract IHuman GetHuman(HumanType humanType);
	public abstract IAnimal GetAnimal(AnimalType animalType);
}
