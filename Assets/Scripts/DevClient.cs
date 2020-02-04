using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevClient : MonoBehaviour
{
	public NPCSpawner m_SpawnerNPC;
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.U))
		{
			m_SpawnerNPC.SpawnHumans();
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			m_SpawnerNPC.SpawnAnimals();
		}
	}
}