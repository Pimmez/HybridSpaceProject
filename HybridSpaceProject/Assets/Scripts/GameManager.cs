using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Image image;
	[SerializeField] private Animator anim;

	public void ChangeSprite(Sprite _UpdateSprite)
	{
		image.sprite = _UpdateSprite;
	}

	public void ChangeSpriteWithAnimation(string _stateName)
	{
		anim.Play(_stateName);
	}
}