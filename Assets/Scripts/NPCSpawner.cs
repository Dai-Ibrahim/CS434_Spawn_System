using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
	private IAnimal m_Cat;
	private IAnimal m_Bird;
	private IHuman m_Farmer;
	private IHuman m_FratBoi;
	private IHuman m_Shopowner;
	private AbstractFactory factory;
	
	public void SpawnAnimals()
	{
		factory = FactoryProducer.GetFactory(FactoryType.Animal);
		m_Cat = factory.GetAnimal(AnimalType.Cat);
		m_Bird = factory.GetAnimal(AnimalType.Bird);m_Cat.Voice();
		m_Bird.Voice();
	}
	public void SpawnHumans()
	{
		factory = FactoryProducer.GetFactory(FactoryType.Human);
		m_FratBoi = factory.GetHuman(HumanType.FratBoi);
		m_Farmer = factory.GetHuman(HumanType.Farmer);
		m_Shopowner = factory.GetHuman(HumanType.Shopowner);
		m_FratBoi.Speak();
		m_Farmer.Speak();
		m_Shopowner.Speak();
	}
}