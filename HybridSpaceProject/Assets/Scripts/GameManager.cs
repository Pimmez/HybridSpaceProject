using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Image image;
	[SerializeField] private Animator anim;
	private bool isActive;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	public void FasesToChange(GameObject _gameObject)
	{
		isActive = !isActive;
		_gameObject.SetActive(isActive);
	}

	public void ChangeSpriteWithAnimation(string _stateName)
	{
		anim.Play(_stateName);
	}
}