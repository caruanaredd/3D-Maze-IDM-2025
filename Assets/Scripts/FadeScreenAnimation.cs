using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeScreenAnimation : MonoBehaviour
{
    // The screen to show
    public CanvasGroup canvasGroup;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FadeScreenRoutine());
    }

    private IEnumerator FadeScreenRoutine()
    {
        float duration = 0.5f;
        float timer = 0;
        
        canvasGroup.alpha = 0;

        yield return new WaitForSeconds(0.25f);

        // if timer > duration, stop
        while (timer < duration)
        {
            // increment the timer every frame
            timer = timer + Time.deltaTime;
            float distance = timer / duration;

            // change the canvasGroup transparency
            canvasGroup.alpha = distance;
            
            // wait for one frame
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(2);

        // timer will continue until it is zero
        while (timer > 0)
        {
            // increment the timer every frame
            timer = timer - Time.deltaTime;
            float distance = timer / duration;

            // change the canvasGroup transparency
            canvasGroup.alpha = distance;
            
            // wait for one frame
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene");
    }
}
