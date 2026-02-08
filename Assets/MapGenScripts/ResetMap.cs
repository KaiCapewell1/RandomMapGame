using UnityEngine;

public class ResetMap : MonoBehaviour
{
    public Transform mapParent;
    [SerializeField] private points points;


    public void Nuke()
    {

        for (int i = mapParent.childCount -1 ; i >= 0; i--)
        {
            Destroy(mapParent.GetChild(i).gameObject);
        }

        points.AddPoint();


    }
}
