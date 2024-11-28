using System;
using UnityEngine;
using UnityEngine.UI;

public class CButton : MonoBehaviour
{
	public Image image;

	public Sprite activeSprite;

	public Sprite inactiveSprite;

	public Color activeTextColor;

	public Color inActiveTextColor;

	public Button button;

	public GameObject buttonText;

	private bool isActive = true;

	private void Awake()
	{
		image = GetComponent<Image>();
	}

	public bool IsActive()
	{
		return isActive;
	}

	public void SetText(string text)
	{
		if (buttonText != null)
		{
			buttonText.SetText(text);
		}
	}

	public void SetActiveSprite(bool isActive)
	{
		this.isActive = isActive;
		if (button != null)
		{
			button.interactable = isActive;
		}
		if (buttonText != null)
		{
			buttonText.GetComponent<Text>().color = ((!isActive) ? inActiveTextColor : activeTextColor);
		}
		/*for (int i = 0; i < images.Length; i++)
		{
			image.sprite = ((!isActive) ? inactiveSprites[i] : activeSprites[i]);
		}*/
		image.sprite = ((!isActive) ? inactiveSprite : activeSprite);
	}
}
