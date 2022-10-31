using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrianManager : MonoBehaviour
{
    public GameObject targetTerrain;
    public GameObject hint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * 1. 第一次点击地块时
     * 2. 点击同一重复地块时
     * 3. 点击不同地块时
     */
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null )
            {
                if (targetTerrain == null )
                {
                    targetTerrain = hit.collider.gameObject;
                    //targetTerrain.selected = true;
                    Debug.Log(targetTerrain.name);
                    //hint.transform.localPosition = targetTerrain.transform.localPosition;

                }
                else if (hit.collider.gameObject == targetTerrain )
                {
                    targetTerrain = null;
                    //targetTerrain.selected = false;
                    //hint.transform.localPosition = new Vector3(-2000,2000,0);
                }else
                {
                    targetTerrain = hit.collider.gameObject;
                    //targetTerrain.selected = false;
                    Debug.Log(targetTerrain.name);
                    //hint.transform.localPosition = targetTerrain.transform.localPosition;
                }
            }
            
    }else if (Input.GetMouseButtonDown(2)){
        if(targetTerrain != null)
        {
            targetTerrain = null;
        }
        }
}
    public void DeSelect()
    {
        if (targetTerrain != null )
        {
            //targetTerrain.selected = false;
            targetTerrain = null;
        }
    }
}
