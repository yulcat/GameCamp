using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class DelayedTrigger : TriggerObject
{
	public float delay;
	bool started = false;
	float time = 0f;

	public void Update()
	{
		if (delay <= 0)
			throw new InvalidCastException ("Given delay value is invalid.");

		if (!started) {
			foreach(TriggerObject obj in triggers) if(!obj.triggered) return;
			started = true;
		}

		if (time < delay) {
			time += Time.deltaTime;
			return;
		}

		triggered = true;
	}

	public override void Reset ()
	{
		base.Reset ();
		time = 0f;
		started = false;
	}
}
