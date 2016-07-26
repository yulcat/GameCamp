using UnityEngine;
using System.Collections;

public class NotTrigger : TriggerObject
{
	public TriggerObject trigger;

	public void Update()
	{
		foreach (TriggerObject obj in triggers) if (!obj.triggered) { triggered = false; return; }

		if (trigger.triggered) {
			triggered = false;
		} else {
			triggered = true;
		}
	}
}
