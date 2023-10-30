using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public GameObject AllObjectParent;
    public string imageTargetTag = "ImageTarget";

    int currentSelectedObject;
    List<GameObject> objects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GetAllObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetAllObjects()
    {
        Transform[] objectTransforms = AllObjectParent.GetComponentsInChildren<Transform>();
        for(int i = 0; i < objectTransforms.Length; i++)
        {
            if (objectTransforms[i].CompareTag(imageTargetTag))
            {
                objects.Add(objectTransforms[i].gameObject);
            }
        }
        Debug.Log("Total Objects : " + objects.Count);
    }
}
