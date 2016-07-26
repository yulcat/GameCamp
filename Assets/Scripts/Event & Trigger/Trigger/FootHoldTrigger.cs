using UnityEngine;
using System.Collections;

public class FootHoldTrigger : TriggerObject
{
	public Collider2D FootHold;
	public bool useOnlyOnce = false;

	public void OnTriggerStay2D(Collider2D other)
	{
		foreach(TriggerObject obj in triggers) if(!obj.triggered) return;
		PlayerControl player = other.gameObject.GetComponent<PlayerControl> ();

		if (player != null) {
			triggered = true;
		}
	}

	public void OnTriggerExit2D(Collider2D other)
	{
		if (useOnlyOnce)
			return;

		PlayerControl player = other.gameObject.GetComponent<PlayerControl> ();

		if (player != null) {
			triggered = false;
		}
	}
}
