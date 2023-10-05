using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelControl : MonoBehaviour
{
    public GameObject Model;

    private Vector3 Pos;

    private void Start()
    {
        Pos = Model.gameObject.GetComponent<Transform>().position;
    }

    public void moveUp() //往上
    {
        Model.transform.Translate(0f, 0.1f, 0f);
        Debug.Log("上");
        Pos = Model.transform.position;
    }

    public void moveDown() //往下
    {
        Model.transform.Translate(0f, -0.1f, 0f);
        Pos = Model.transform.position;
    }

    public void moveLeft() //往左
    {
        Model.transform.Translate(-0.1f, 0f, 0f);
        Pos = Model.transform.position;
    }

    public void moveRight() //往右
    {
        Model.transform.Translate(0.1f, 0f, 0f);
        Pos = Model.transform.position;
    }

    public void moveForward() //往前
    {
        Model.transform.Translate(0f, 0f, -0.1f);
        Pos = Model.transform.position;
    }

    public void moveOnward() //往後
    {
        Model.transform.Translate(0f, 0f, 0.1f);
        Pos = Model.transform.position;
    }

    public void turnLeft() //左轉
    {
        Model.transform.Rotate(0f, -10f, 0f);
        Pos = Model.transform.position;
    }

    public void turnRight() //右轉
    {
        Model.transform.Rotate(0f, 10f, 0f);
        Pos = Model.transform.position;
    }

    public void rotateUp() //上轉
    {
        Model.transform.Rotate(10f, 0f, 0f);
        Pos = Model.transform.position;
    }

    public void rotateDown() //下轉
    {
        Model.transform.Rotate(-10f, 0f, 0f);
        Pos = Model.transform.position;
    }

    public void ResetPosition()
    {
        SceneManager.LoadScene("SampleScene"); //直接重置整個場景
    }
}
