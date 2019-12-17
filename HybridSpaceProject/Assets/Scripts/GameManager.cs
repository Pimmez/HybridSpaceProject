using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Image image;

	public void ChangeSprite(Sprite _UpdateSprite)
	{
		image.sprite = _UpdateSprite;
	}
}