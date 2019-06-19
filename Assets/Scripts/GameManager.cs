using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public Text scoreTxt;
    public int score_;
    public static GameManager instance;
    public GameObject[] spawnPoint;
    public GameObject[] WasteObjects;
    public GameObject[] tables;
    public UnityEvent OnStart;
    public List<GameObject> spawnobjects;
    public bool raccoon;
    private int my_Score = 0;
    private int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score_ = 0;

        OnStart.Invoke();
        raccoon = false;
    }

    // Update is called once per frame
    void Update()
    {
            
            scoreTxt.text = score_.ToString();
    }

    public void SpawnObject(WasteType wasteType)
    {
        int i = Random.Range(0, spawnPoint.Length);
        Waste t = Instantiate(WasteObjects[(int)wasteType], spawnPoint[i].transform.position, WasteObjects[(int)wasteType].transform.rotation).GetComponent<Waste>();
        t.StartingPippe = spawnPoint[i].GetComponent<PipeInfo>().pipe;
    }


    public void SpawnObject(int wasteType)
    {
        int i = Random.Range(0, spawnPoint.Length);
        Waste t = Instantiate(WasteObjects[wasteType], spawnPoint[i].transform.position, WasteObjects[wasteType].transform.rotation).GetComponent<Waste>();
        t.StartingPippe = spawnPoint[i].GetComponent<PipeInfo>().pipe;
    }
    public void SpawnObjects()
    {
        Debug.Log("A");
        Instantiate(WasteObjects[Random.Range(0, WasteObjects.Length)], spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);

    }
    public void TableSpawn()
    {
        my_Score += 10;
        if (my_Score >= 50 && i <= tables.Length)
        {
            tables[i].SetActive(true);
            i++;
            my_Score = 0;
        }
    }
    
    




}
