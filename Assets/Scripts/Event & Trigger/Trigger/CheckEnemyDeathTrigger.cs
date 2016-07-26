using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckEnemyDeathTrigger : TriggerObject
{
	public List<GameObject> spawnedEnemy = new List<GameObject> ();
	public bool isEnemyAlreadySpawned = false;
	bool getData = false;

	public void GetEnemy(List<GameObject> enemies)
	{
		if (enemies.Count == 0)
			return;

		spawnedEnemy.AddRange (enemies);
		getData = true;
	}

	public void Update()
	{
		foreach(TriggerObject obj in triggers) if(!obj.triggered) return;
		if (!getData && !isEnemyAlreadySpawned)
			return;

		foreach (GameObject enemy in spawnedEnemy) {
			if (enemy != null)
				return;
		}

		triggered = true;
	}

	public override void Reset ()
	{
		base.Reset ();
		getData = false;
		spawnedEnemy.Clear ();
	}
}
