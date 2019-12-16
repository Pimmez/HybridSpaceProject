using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] private List<GameObject> imageObjects = new List<GameObject>();

	public void StartSomething(Image _image)
	{
		for (int i = 0; i < imageObjects.Count; i++)
		{
			imageObjects[0].SetActive(true);
		}
	}

	public void EMOTE1(GameObject _emote1)
	{

	}
}