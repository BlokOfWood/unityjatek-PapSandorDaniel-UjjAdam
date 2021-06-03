using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFocusPoint : MonoBehaviour
{
    public GameObject Background;
    float BackgroundAspectRatio;
    public List<GameObject> players = new List<GameObject>();
    public float EdgePadding;
    public float MinimumSize;
    public Cinemachine.CinemachineVirtualCamera virtualCamera;

    GameObject bravoObject;

    private void Awake()
    {
        players = new List<GameObject>();
        BackgroundAspectRatio = Background.transform.localScale.x / Background.transform.localScale.y;
        bravoObject = GameObject.Find("padlo (22)").GetComponent<Win>().BravoObject;
    }

    private void Update()
    {
        players.RemoveAll(x => x == null);

        if (players.Count == 0)
        {

#if UNITY_EDITOR
            EditorSceneManager.LoadScene(0);
#endif
#if UNITY_STANDALONE
            SceneManager.LoadScene(0);
#endif
            return;
        }

        Vector3 middlePoint = new Vector3(0,0,0);

        List<Vector3> positions = players.ToList().ConvertAll(x => x.transform.position);

        foreach(Vector3 i in positions)
        {
            middlePoint += i;
        }
        middlePoint /= players.Count;

        try
        {
            if (transform)
            {
                transform.position = middlePoint;
            }
        }
        catch(Exception)
        {
            return;
        }

        var ortographicHeight = Mathf.Abs(players[0].transform.position.y - middlePoint.y);
        var ortographicWidth = Mathf.Abs(players[0].transform.position.x - middlePoint.x) / virtualCamera.m_Lens.Aspect;
        virtualCamera.m_Lens.OrthographicSize = Mathf.Max(ortographicHeight, ortographicWidth, MinimumSize) + EdgePadding;

        Background.transform.localScale = new Vector3(virtualCamera.m_Lens.OrthographicSize * 0.8f * BackgroundAspectRatio, virtualCamera.m_Lens.OrthographicSize * 0.8f, 1);
        bravoObject.transform.localScale = new Vector3(virtualCamera.m_Lens.OrthographicSize * 0.16f * BackgroundAspectRatio, virtualCamera.m_Lens.OrthographicSize * 0.28f, 1);
    }
}
