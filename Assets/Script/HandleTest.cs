using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HandleTest : MonoBehaviour
{
    public TMP_InputField inputKinhDo;
    public TMP_InputField inputViDo;
    public TMP_InputField inputNgay;
    public TMP_InputField inputThang;
    public TMP_InputField inputThoiGian;
    public Button buttonToaDo;
    public Button buttonThoiGian;
    public Button buttonThoiGianThuc;
    public Transform sun;
    // Start is called before the first frame update
    void Start()
    {
        buttonToaDo.onClick.AddListener(HandleToaDo);
        buttonThoiGian.onClick.AddListener(delegate { HandleThoiGian(float.Parse(inputThoiGian.text)); });
        buttonThoiGianThuc.onClick.AddListener(HandleThoiGianThuc);
    }

    public virtual void HandleToaDo()
    {
        if (inputKinhDo.text.Trim().Length < 1) inputKinhDo.text = "0";
        if (inputViDo.text.Trim().Length < 1) inputViDo.text = "0";
        sun.rotation = Quaternion.Euler(float.Parse(inputViDo.text), float.Parse(inputKinhDo.text), 0f);
    }

    public virtual void HandleThoiGianThuc()
    {
        var realTime = DateTime.Now.Hour;
        HandleThoiGian(realTime);
    }

    public virtual void HandleThoiGian(float time)
    {
        if (time < 6)
        {
            sun.rotation = Quaternion.Euler(-45f + time * 7.5f, 0f, 0f);
        }
        else if(time >=6 && time <= 12)
        {
            sun.rotation = Quaternion.Euler(time * 7.5f, 0f, 0f);
        }
        else if(time > 12 && time <= 18)
        {
            sun.rotation = Quaternion.Euler(45f + time * 7.5f, 0f, 0f);
        }
        else
        {
            sun.rotation = Quaternion.Euler(-270f + time * 7.5f, 0f, 0f);
        }

    }
}
