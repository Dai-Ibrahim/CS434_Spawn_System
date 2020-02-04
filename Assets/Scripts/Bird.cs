using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : IAnimal
{
    public void Voice()
	{
		Debug.Log("Bird: Tweet!");
	}
}
