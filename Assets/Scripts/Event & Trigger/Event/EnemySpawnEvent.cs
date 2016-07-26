using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawnEvent : EventObject
{
	public List<GameObject> enemyList = new List<GameObject> ();
	public List<Transform> spawnPositions = new List<Transform> ();
	public CheckEnemyDeathTrigger checkTrigger;
	List<GameObject> spawnedEnemy = new List<GameObject> ();

	public override void TriggerEvent()
	{
		if (enemyList.Count != spawnPositions.Count)
			Debug.LogError("Enemy List and Spawn position count is not matched.");

		if (alreadyHappened)
			return;

		if (enemyList.Count == 0)
			return;

		for (int i = 0; i < enemyList.Count; i++) {
			GameObject.Instantiate (enemyList [i], spawnPositions [i].position, Quaternion.identity);
		}

		alreadyHappened = true;
		triggered = true;
		checkTrigger.GetEnemy (enemyList);
	}

	public override void Reset()
	{
		base.Reset ();
		//enemyLiving = false;
		spawnedEnemy.Clear ();
	}
}
