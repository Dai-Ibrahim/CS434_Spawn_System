using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class WhenClicked : MonoBehaviour
{	string option;
	ClothesRequirements requirements = new ClothesRequirements();
	public GameObject Tux;
	public GameObject Swimwear;
	public GameObject Sundress;
	public GameObject BusinessProf;
	public GameObject BusinessCas;
	public GameObject CocktailDress;
	public GameObject DressyCas;
	public GameObject Casual;
	public GameObject EveningDress;




    public void ButtonPressed(Button button)
	{
		option = button.name;
		Debug.Log(option);
		
		switch (option)
		{
			case ("Beach"):
				requirements.Location = 1;
				break;
			case("Venue"):
				requirements.Location = 2;
				break;
			case("Office"):
				requirements.Location = 3;
				break;
			case("House"):
				requirements.Location = 4;
				break;
			case("Woman"):
				requirements.Woman = true;
				break;
			case("Man"):
				requirements.Woman = false;
				break;
			case("Formal"):
				requirements.Formal = true;
				break;
			case ("Informal"):
				requirements.Formal = false;
				break;
			case ("Create"):
				ClothesFactory factory = new ClothesFactory(requirements);
				IClothes v = factory.Create();
				createPressed(v);
				break;
			
			default:
				requirements.Location = 2;
				requirements.Woman = true;
				requirements.Formal = false;
				break;
			}
			
			//return 0;

		}
		public void createPressed(IClothes v)
		{
			DestroyAllObjects();
			if (v.ToString() == "Tuxedo" && (GameObject.Find("Tux(Clone)") == null))
			{
				Instantiate(Tux);
			}
			if (v.ToString() == "Swimwear" && (GameObject.Find("Swimwear(Clone)") == null))
			{
				Instantiate(Swimwear);
			}
			if (v.ToString() == "SunDress" && (GameObject.Find("Sundress(Clone)") == null))
			{
				Instantiate(Sundress);
			}
			if (v.ToString() == "BusinessProfessional" && (GameObject.Find("BusinessProf(Clone)") == null))
			{
				Instantiate(BusinessProf);
			}
			if (v.ToString() == "BusinessCasual" && (GameObject.Find("BusinessCas(Clone)") == null))
			{
				Instantiate(BusinessCas);
			}
			if (v.ToString() == "CocktailDress" && (GameObject.Find("CocktailDress(Clone)") == null))
			{
				Instantiate(CocktailDress);
			}
			if (v.ToString() == "DressyCasual" && (GameObject.Find("DressyCas(Clone)") == null))
			{
				Instantiate(DressyCas);
			}
			if (v.ToString() == "CasualWear" && (GameObject.Find("Casual(Clone)") == null))
			{
				Instantiate(Casual);
			}
			if (v.ToString() == "EveningDress" && (GameObject.Find("EveningDress(Clone)") == null))
			{
				Instantiate(EveningDress);
			}
		}
		void DestroyAllObjects()
 		{
      		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Clothes");
     
     		for(var i = 0 ; i < gameObjects.Length ; i ++)
     		{
				Destroy(gameObjects[i]);
		 	}
 		}		
}
	 
  

