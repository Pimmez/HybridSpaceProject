using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayActivation : MonoBehaviour
{
	private void Awake()
	{
		for (int i = 0; i < Display.displays.Length; i++)
		{
			Display.displays[i].Activate(1920, 1080, 60);
		}

		if (Display.displays.Length > 1)
		{
			//display 0 is set by default
			Display.displays[1].Activate();
			Display.displays[1].SetParams(1920, 1080, 0, 0);
		}
		if (Display.displays.Length > 2)
		{
			Display.displays[2].Activate();
			Display.displays[2].SetParams(1920, 1080, 0, 0);
		}

	}
}