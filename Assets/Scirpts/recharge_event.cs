using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recharge_event : MonoBehaviour {

    [SerializeField]
    ToggleGroup group;
    [SerializeField]
    HttpModel http;


    private void OnEnable()
    {
        if (Static.Instance.GetValue("zzflag") == "0")
            group.gameObject.SetActive(false);
        else
            group.gameObject.SetActive(true);
    }

    public void Onclick()
    {
        if (Static.Instance.GetValue("zzflag") != "0")
        {
            IEnumerable<Toggle> toggleGroup = group.ActiveToggles();
            foreach (Toggle t in toggleGroup)
            {//遍历这个存放Toggle的按钮组IEnumerable，此乃C#的一个枚举集合，一般直接用foreach遍历
                if (t.isOn)//遍历到一个被选择的Toggle
                {
                    Static.Instance.AddValue("ppflag", t.name);
                }
            }
        }
        

        else
            Static.Instance.AddValue("ppflag", "0");

        http.Get();
    }
}
