using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighlightObject : MonoBehaviour
{
    [SerializeField] private Image _fader;
    [SerializeField] private List<Button> buttons;
    private TMP_Text targetText;
    private string originalText;

    private float alphaValue = 0.87f;
    private bool isFading;

    public void Init(TMP_Text textToModify)
    {
        targetText = textToModify;
        originalText = textToModify.text;
    }

    public void OnButtonPressed(Button clickedButton)
    {
        foreach (var btn in buttons)
            btn.gameObject.SetActive(btn == clickedButton);

        StartCoroutine(Fade(alphaValue));

        clickedButton.GetComponent<ButtonTextChanger>().OnButtonPressed(targetText);
    }

    public void OnBackButtonPressed()
    {
        if (isFading) return;

        StartCoroutine(Fade(0f));
        targetText.text = originalText;
    }

    private IEnumerator Fade(float targetAlpha)
    {
        isFading = true;
        _fader.gameObject.SetActive(true);

        Color c = _fader.color;

        while (!Mathf.Approximately(c.a, targetAlpha))
        {
            c.a = Mathf.MoveTowards(c.a, targetAlpha, Time.deltaTime * 2);
            _fader.color = c;
            yield return null;
        }

        if (targetAlpha == 0f)
        {
            _fader.gameObject.SetActive(false);

            foreach (var btn in buttons)
                btn.gameObject.SetActive(true);
        }

        isFading = false;
    }


}
