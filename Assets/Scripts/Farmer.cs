using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : IHuman
{
    // Start is called before the first frame update
    public void Speak()
	{
		Debug.Log("Farmer: You reap what you sow!");
	}
}
