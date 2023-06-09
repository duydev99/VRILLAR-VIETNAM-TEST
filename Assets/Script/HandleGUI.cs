using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class HandleGUI : MonoBehaviour
{
    public TMP_InputField inputKinhDo;
    public TMP_InputField inputViDo;
    public TMP_InputField inputNgay;
    public TMP_InputField inputThang;
    public TMP_InputField inputThoiGian;

    // Start is called before the first frame update
    void Start()
    {
        inputKinhDo.onValueChanged.AddListener(delegate { OnChangeKinhDo(); });
        inputViDo.onValueChanged.AddListener(delegate { OnChangeViDo(); });
        inputNgay.onValueChanged.AddListener(delegate { OnChangeNgay(); });
        inputThang.onValueChanged.AddListener(delegate { OnChangThang(); });
        inputThoiGian.onValueChanged.AddListener(delegate { OnChangeThoiGian(); });
    }

    public virtual void OnChangeKinhDo()
    {
        if (float.Parse(inputKinhDo.text) < 0f)
            inputKinhDo.text = "0";

        if(float.Parse(inputKinhDo.text) > 180f)
            inputKinhDo.text = "180";
    }

    public virtual void OnChangeViDo()
    {
        if (float.Parse(inputViDo.text) < 0f)
            inputViDo.text = "0";

        if (float.Parse(inputViDo.text) > 180f)
            inputViDo.text = "180";
    }

    public virtual void OnChangeNgay()
    {
        if (float.Parse(inputNgay.text) < 1)
            inputNgay.text = "1";

        if (float.Parse(inputNgay.text) > 31)
            inputNgay.text = "31";
    }

    public virtual void OnChangThang()
    {
        if (float.Parse(inputThang.text) < 1)
            inputThang.text = "1";

        if (float.Parse(inputThang.text) > 12)
            inputThang.text = "12";
    }

    public virtual void OnChangeThoiGian()
    {
        if (float.Parse(inputThoiGian.text) < 1)
            inputThoiGian.text = "1";

        if (float.Parse(inputThoiGian.text) > 24)
            inputThoiGian.text = "24";
    }

}
