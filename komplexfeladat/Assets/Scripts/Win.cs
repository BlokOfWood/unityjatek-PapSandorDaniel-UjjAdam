using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject BravoObject;
    bool coroutineTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BravoObject.SetActive(true);
            StartCoroutine(Load());
        }
    }

    IEnumerator Load()
    {
        while (true)
        {
            if (coroutineTriggered)
            {
#if UNITY_EDITOR
                EditorApplication.isPlaying = false;
#endif
#if UNITY_STANDALONE
                Application.Quit();
#endif
                break;
            }
            coroutineTriggered = true;
            yield return new WaitForSeconds(2f);
        }
    }
}
