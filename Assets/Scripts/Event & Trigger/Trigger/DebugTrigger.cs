using UnityEngine;
using System.Collections;

public class DebugTrigger : TriggerObject
{
	public void Update()
	{
		foreach (TriggerObject obj in triggers) if (!obj.triggered) return;

		if (Input.GetKeyDown (KeyCode.P))
			triggered = true;
	}
}
