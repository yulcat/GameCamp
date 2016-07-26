using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class TriggerObject : MonoBehaviour
{
	public bool triggered = false;
	public List<TriggerObject> triggers = new List<TriggerObject> ();

	public virtual void Reset()
	{
		triggered = false;
	}
}

