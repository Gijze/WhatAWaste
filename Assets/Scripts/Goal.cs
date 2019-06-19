using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WasteType
{
    Glass,
    GFT,
    Plastic
};

public class Goal : Object_Rotate
{
    public WasteType WasteType;

    new private void Start()
    {

    }

    public void CheckWaste(Waste a_Waste)
    {
        if(a_Waste.WasteType == WasteType)
        {
            Debug.Log("working");
            
            Destroy(a_Waste.gameObject);
        }
        else
            Debug.Log("niet eyo");
        
        Destroy(a_Waste.gameObject);

        

        GameManager.instance.SpawnObject(a_Waste.WasteType);
    }

}
