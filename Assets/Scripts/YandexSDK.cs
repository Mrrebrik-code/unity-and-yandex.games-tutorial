using System.Runtime.InteropServices;
using UnityEngine;

public class YandexSDK : MonoBehaviour
{
	[SerializeField] private TMPro.TMP_Text _text;

	[DllImport("__Internal")]
	private static extern void ShowFullscreenAd();

	public void ShowIntersitial()
	{
		ShowFullscreenAd();
	}

	public void SetMessage(string message)
	{
		_text.text += message + "\n";
	}
}
