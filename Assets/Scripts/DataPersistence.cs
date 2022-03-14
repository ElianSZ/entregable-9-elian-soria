using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    // public GameObject player;
    public float PosX;
    public float PosY;
    public float PosZ;

    public Vector3 pos;

    void Start()
    {
        LoadPlayerPos();
    }

    void Update()
    {
        SavePlayerPos();
    }

    public void SavePlayerPos()
    {
        PlayerPrefs.SetFloat("PositionX", transform.position.x);
        PlayerPrefs.SetFloat("PositionY", transform.position.y);
        PlayerPrefs.SetFloat("PositionZ", transform.position.z);
        Debug.Log("Data saved");
    }

    public void LoadPlayerPos()
    {
        PosX = PlayerPrefs.GetFloat("PositionX");
        PosY = PlayerPrefs.GetFloat("PositionY");
        PosZ = PlayerPrefs.GetFloat("PositionZ");

        pos.x = PosX;
        pos.y = PosY;
        pos.z = PosZ;

        transform.position = pos;
    }
}