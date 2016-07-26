using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class EventObject : TriggerObject
{
	protected bool alreadyHappened = false;
	public abstract void TriggerEvent ();
	public override void Reset ()
	{
		base.Reset ();
		alreadyHappened = false;

		if (triggers.Count != 0) {
			foreach (TriggerObject trigger in triggers) {
				trigger.Reset ();
			}
		}
	}

	//This should be called in Update() of each child.
	public virtual void Update()
	{
		if (triggers.Count != 0) {
			foreach (TriggerObject trigger in triggers) {
				if (trigger==null) Debug.LogWarning(gameObject.name + " is Triggered by null");
			}
		}

		if (alreadyHappened)
			return;

		CheckTrigger ();
	}

	protected virtual void CheckTrigger()
	{
		if (triggers.Count == 0)
			return;

		foreach (TriggerObject trigger in triggers) {
			if (!trigger.triggered)
				return;
		}

		TriggerEvent ();
	}
}