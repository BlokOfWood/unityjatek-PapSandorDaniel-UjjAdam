using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraFocusPoint : MonoBehaviour
{
    public GameObject Background;
    public List<GameObject> players = new List<GameObject>();
    public float EdgePadding;
    public float MinimumSize;
    public Cinemachine.CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        players = new List<GameObject>();
    }

    private void Update()
    {
        Vector3 middlePoint = new Vector3();

        List<Vector3> positions = players.ToList().ConvertAll(x => x.transform.position);

        foreach(Vector3 i in positions)
        {
            middlePoint += i;
        }
        middlePoint /= players.Count;

        transform.position = middlePoint;

        var ortographicHeight = Mathf.Abs(players[0].transform.position.y - middlePoint.y);
        var ortographicWidth = Mathf.Abs(players[0].transform.position.x - middlePoint.x) / virtualCamera.m_Lens.Aspect;
        virtualCamera.m_Lens.OrthographicSize = Mathf.Max(ortographicHeight, ortographicWidth, MinimumSize) + EdgePadding;
  
    }
}
