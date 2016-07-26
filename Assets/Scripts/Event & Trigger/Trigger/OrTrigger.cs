using UnityEngine;
using System.Collections;

public class OrTrigger : TriggerObject
{
	public void Update()
	{
		if (triggers.Count == 0)
			return;

		foreach (TriggerObject trigger in triggers) {
			if (trigger.triggered) {
				triggered = true;
				return;
			}
		}

		triggered = false;
	}

	public override void Reset ()
	{
		base.Reset ();

		if (triggers == null)
			return;

		if (triggers.Count != 0) {
			foreach (TriggerObject trigger in triggers) {
				trigger.Reset ();
			}
		}
	}
}
