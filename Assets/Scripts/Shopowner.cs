using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopowner : IHuman
{
    public void Speak()
	{
		Debug.Log("Shopowner: Do you wish to purchase something?");
	}
}
